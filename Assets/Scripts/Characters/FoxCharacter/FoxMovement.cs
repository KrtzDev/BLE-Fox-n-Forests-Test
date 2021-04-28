using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FoxMovement: MonoBehaviour
{
    [SerializeField]
    private FoxCharacter _thisFoxCharacter;
    [SerializeField]
    private DustParticle _DustParticlePrefab;
    [SerializeField]
    private float _moveSpeed;
    [SerializeField]
    private float _jumpHeight;
    [SerializeField]
    private float _fallMultiplier;
    [SerializeField]
    private LayerMask _groundLayer;

    private float _moveDirection;
    private int _jumpCount = 0;
    private bool _canMove = true;
    private bool _isGrounded;
    private bool _disableJump;
    private InputAction _moveAction;
    private InputAction _jumpAction;

#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        for (int i = 0; i < _thisFoxCharacter.GroundChecks.Length; i++)
        {
            UnityEditor.Handles.DrawWireDisc(_thisFoxCharacter.GroundChecks[i].position, Vector3.back, .01f);
        }
    }
#endif

    private void Awake()
    {
        _thisFoxCharacter = GetComponent<FoxCharacter>();
        _moveAction = _thisFoxCharacter.PlayerInput.actions.FindAction("Move");
        _jumpAction = _thisFoxCharacter.PlayerInput.actions.FindAction("Jump");
    }

    private void FixedUpdate()
    {
        //Better Jump
        if (_thisFoxCharacter.FoxRigidBody.velocity.y < -0.01f)
        {
            _thisFoxCharacter.FoxRigidBody.velocity += new Vector2(0, Physics2D.gravity.y * _fallMultiplier * Time.fixedDeltaTime);
            _thisFoxCharacter.FoxAnimator.SetBool("isFalling",true);
        }
        else
        {
            _thisFoxCharacter.FoxAnimator.SetBool("isFalling", false);
        }

        if (_moveDirection == 0)
        {
            _thisFoxCharacter.FoxRigidBody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;

        }
        else
        {
            _thisFoxCharacter.FoxRigidBody.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        }

        if (_canMove)
        {
            _thisFoxCharacter.FoxRigidBody.velocity = new Vector2(Mathf.Clamp(_thisFoxCharacter.FoxRigidBody.velocity.x + _moveDirection * _moveSpeed * Time.fixedDeltaTime,-1,1), _thisFoxCharacter.FoxRigidBody.velocity.y);
        }
    }

    private void Update()
    {
        IsGrounded();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (_canMove)
        {
            if (context.performed || context.phase == InputActionPhase.Waiting)
            {
                _moveDirection = context.ReadValue<float>();
                FlipSprite();
            }
        }
        if (context.canceled)
        {
            _moveDirection = 0;
        }

        _thisFoxCharacter.FoxAnimator.SetFloat("movement", Mathf.Abs(_moveDirection));
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (context.started && CanJump() && _disableJump == false)
        {
            _jumpCount++;
            _thisFoxCharacter.FoxRigidBody.velocity = new Vector2(_thisFoxCharacter.FoxRigidBody.velocity.x, _jumpHeight);
            _thisFoxCharacter.FoxAnimator.SetTrigger("jump");
            _thisFoxCharacter.FoxAnimator.SetBool("isGrounded", false);
        }
    }

    public void DisableMovement()
    {
        _canMove = false;
        _disableJump = true;
        _thisFoxCharacter.FoxMovement._moveDirection = 0;
    }

    public void EnableMovement()
    {
        _canMove = true;
        _disableJump = false;
        _thisFoxCharacter.FoxMovement._moveDirection = _moveAction.ReadValue<float>();
        _thisFoxCharacter.FoxAnimator.SetFloat("movement", Mathf.Abs(_moveDirection));
        FlipSprite();
    }

    public void ApplyKnockBack(GameObject damageDealer,float knockBackForce)
    {
        Vector2 knockBackDirection = new Vector2((this.transform.position.x - damageDealer.transform.position.x) ,1f);

        _moveDirection = knockBackDirection.x;
        _thisFoxCharacter.FoxRigidBody.AddForce(knockBackDirection * knockBackForce);

        StartCoroutine(KnockBack());
    }

    public bool IsGrounded()
    {
        for (int i = 0; i < _thisFoxCharacter.GroundChecks.Length; i++)
        {
            if (Physics2D.OverlapCircle(_thisFoxCharacter.GroundChecks[i].position, .01f, _groundLayer))
            {
                if (!_isGrounded)
                {
                    _jumpCount = 0;
                }
                _isGrounded = true;
                _thisFoxCharacter.FoxAnimator.SetBool("isGrounded", true);
                return true;
            }
        }
        _isGrounded = false;
        _thisFoxCharacter.FoxAnimator.SetBool("isGrounded", false);
        return false;
    }

    private bool CanJump()
    {
        if (IsGrounded() || _jumpCount < 2)
        {
            _thisFoxCharacter.FoxAnimator.SetBool("canJump",true);
            return true;
        }
        _thisFoxCharacter.FoxAnimator.SetBool("canJump", false);
        return false;
    }

    private void FlipSprite()
    {
        if (_moveDirection < 0)
        {
            _thisFoxCharacter.FoxSpriteRenderer.flipX = true;
            _thisFoxCharacter.CurrentProjectileSpawn = _thisFoxCharacter.LeftProjectileSpawn;
        }
        if (_moveDirection > 0)
        {
            _thisFoxCharacter.FoxSpriteRenderer.flipX = false;
            _thisFoxCharacter.CurrentProjectileSpawn = _thisFoxCharacter.RightProjectileSpawn;
        }
    }

    public void SpawnDustOnStep()
    {
        Instantiate(_DustParticlePrefab,_thisFoxCharacter.DustParticleSpawn.position,Quaternion.identity);
    }

    IEnumerator KnockBack()
    {
        yield return new WaitForSeconds(.3f);
        EnableMovement();
    }
}
