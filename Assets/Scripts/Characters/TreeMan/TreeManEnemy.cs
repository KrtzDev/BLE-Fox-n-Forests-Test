using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManEnemy : MonoBehaviour
{
    [SerializeField]
    private TreeManMovement _treeManMovement;
    [SerializeField]
    private Transform _treeManTransform;
    [SerializeField]
    private SpriteRenderer _treeManSpriteRenderer;
    [SerializeField]
    private BoxCollider2D _treeManCollider;
    [SerializeField]
    private Animator _treeManAnimator;

    private Transform _leftMovementBorder;
    private Transform _rightMovementBorder;

    public TreeManMovement TreeManMovement { get => _treeManMovement; set => _treeManMovement = value; }
    public Transform TreeManTransform { get => _treeManTransform; set => _treeManTransform = value; }
    public SpriteRenderer TreeManSpriteRenderer { get => _treeManSpriteRenderer; set => _treeManSpriteRenderer = value; }
    public BoxCollider2D TreeManCollider { get => _treeManCollider; set => _treeManCollider = value; }
    public Animator TreeManAnimator { get => _treeManAnimator; set => _treeManAnimator = value; }
    public Transform LeftMovementBorder { get => _leftMovementBorder; set => _leftMovementBorder = value; }
    public Transform RightMovementBorder { get => _rightMovementBorder; set => _rightMovementBorder = value; }
}
