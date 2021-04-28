using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class SpawnPlayer : MonoBehaviour
{
    [SerializeField]
    private FoxCharacter _foxCharacterPrefab;
    [SerializeField]
    private CinemachineVirtualCamera _camera;

    private FoxCharacter _currentFoxCharacter;

    private void Awake()
    {
        _currentFoxCharacter = Instantiate(_foxCharacterPrefab,this.transform.position,Quaternion.identity);
        _camera.Follow = _currentFoxCharacter.transform;
        _camera.LookAt = _currentFoxCharacter.transform;
    }
}
