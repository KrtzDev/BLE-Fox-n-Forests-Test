using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FoxCharacter : MonoBehaviour
{
    [SerializeField]
    private FoxMovement _foxMovement;

    [SerializeField]
    private Rigidbody2D _foxRigidBody;

    [SerializeField]
    private BoxCollider2D _foxCollider;

    [SerializeField]
    private SpriteRenderer _foxSpriteRenderer;

    [SerializeField]
    private Animator _foxAnimator;

    [SerializeField]
    private PlayerInput _playerInput;

    [SerializeField]
    private Transform _rightProjectileSpawn;

    [SerializeField]
    private Transform _leftProjectileSpawn;

    [SerializeField]
    private Transform _currentProjectileSpawn;

    [SerializeField]
    private Transform _dustParticleSpawn;

    [SerializeField]
    private Transform[] _groundChecks;

    public FoxMovement FoxMovement { get => _foxMovement; set => _foxMovement = value; }
    public Rigidbody2D FoxRigidBody { get => _foxRigidBody; set => _foxRigidBody = value; }
    public BoxCollider2D FoxCollider { get => _foxCollider; set => _foxCollider = value; }
    public SpriteRenderer FoxSpriteRenderer { get => _foxSpriteRenderer; set => _foxSpriteRenderer = value; }
    public Animator FoxAnimator { get => _foxAnimator; set => _foxAnimator = value; }
    public PlayerInput PlayerInput { get => _playerInput; set => _playerInput = value; }
    public Transform RightProjectileSpawn { get => _rightProjectileSpawn; set => _rightProjectileSpawn = value; }
    public Transform LeftProjectileSpawn { get => _leftProjectileSpawn; set => _leftProjectileSpawn = value; }
    public Transform CurrentProjectileSpawn { get => _currentProjectileSpawn; set => _currentProjectileSpawn = value; }
    public Transform DustParticleSpawn { get => _dustParticleSpawn; set => _dustParticleSpawn = value; }
    public Transform[] GroundChecks { get => _groundChecks; set => _groundChecks = value; }
}
