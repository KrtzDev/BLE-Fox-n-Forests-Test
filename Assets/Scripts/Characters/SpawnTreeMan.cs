using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTreeMan : MonoBehaviour
{
    [SerializeField]
    private TreeManEnemy _treeManEnemyPrefab;
    [SerializeField]
    private Transform _leftMovementBorder;
    [SerializeField]
    private Transform _rightMovementBorder;

    private TreeManEnemy _currentTreeManEnemy;


    private void Awake()
    {
        _currentTreeManEnemy = Instantiate(_treeManEnemyPrefab,this.transform.position,Quaternion.identity);
        _currentTreeManEnemy.LeftMovementBorder = _leftMovementBorder;
        _currentTreeManEnemy.RightMovementBorder = _rightMovementBorder;
    }
}
