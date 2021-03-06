using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField]
    private int _levelIndexToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GetToNextLevel();
        }
    }

    private void GetToNextLevel()
    {
        SceneManager.LoadScene(_levelIndexToLoad);
    }
}
