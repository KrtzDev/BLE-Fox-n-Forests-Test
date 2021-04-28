using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManMovement : MonoBehaviour
{
    [SerializeField]
    private TreeManEnemy _thisTreeManEnemy;

    [SerializeField]
    private float _treeManMoveSpeed;

    private Vector3 _movementDirection;

    private void Awake()
    {
        _thisTreeManEnemy = GetComponent<TreeManEnemy>();
        _movementDirection = Vector3.right * _treeManMoveSpeed * Time.fixedDeltaTime;
        _thisTreeManEnemy.TreeManSpriteRenderer.flipX = true;
    }

    private void FixedUpdate()
    {
        MoveTreeMan();
    }

    private void MoveTreeMan()
    {

        if (_thisTreeManEnemy.TreeManTransform.position.x > _thisTreeManEnemy.RightMovementBorder.position.x)
        {
            _movementDirection = Vector3.left * _treeManMoveSpeed * Time.fixedDeltaTime;
            _thisTreeManEnemy.TreeManSpriteRenderer.flipX = false;
        }
        else if (_thisTreeManEnemy.TreeManTransform.position.x < _thisTreeManEnemy.LeftMovementBorder.position.x)
        {
            _movementDirection = Vector3.right * _treeManMoveSpeed * Time.fixedDeltaTime;
            _thisTreeManEnemy.TreeManSpriteRenderer.flipX = true;
        }

        _thisTreeManEnemy.TreeManTransform.position += _movementDirection;
    }
}
