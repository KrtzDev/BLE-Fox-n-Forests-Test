using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class FoxAttack : MonoBehaviour
{
    [SerializeField]
    private FoxCharacter _thisFoxCharacter;
    [SerializeField]
    private ArrowProjectile arrowProjectilePrefab;
    [SerializeField]
    private int _maxArrows;

    private int _arrowCount;

    private ArrowProjectile _spawnedArrow;
 
    private void Awake()
    {
        _thisFoxCharacter = GetComponent<FoxCharacter>();       
    }

    public void OnShoot(InputAction.CallbackContext context)
    {      
        if (context.performed && _thisFoxCharacter.FoxMovement.IsGrounded())
        {
            if (_arrowCount < _maxArrows)
            {
            _thisFoxCharacter.FoxMovement.DisableMovement();
            ShootArrow();
            }
        }      
    }

    private void ShootArrow()
    {
        _thisFoxCharacter.FoxAnimator.SetTrigger("shoot");
        _arrowCount++;       
    }

    public void SpawnArrow()
    {
        _spawnedArrow = Instantiate(arrowProjectilePrefab, _thisFoxCharacter.CurrentProjectileSpawn.transform.position, _thisFoxCharacter.CurrentProjectileSpawn.transform.rotation);
        _spawnedArrow.ArrowDestroyed.AddListener(ArrowDestroyed);
    }

    private void ArrowDestroyed()
    {
        _arrowCount--;
    }
}
