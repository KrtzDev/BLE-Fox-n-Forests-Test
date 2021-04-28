using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class MainMenuController : MonoBehaviour
{

    private MainMenu _currentMainMenu;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += UpdateCurrentUI;
    }

    private void OnDisable()
    {
        _currentMainMenu.StartButton.onClick.RemoveListener(StartGame);
        _currentMainMenu.QuitButton.onClick.RemoveListener(QuitGame);
        _currentMainMenu.ControllsButton.onClick.RemoveListener(ShowControllsUI);
        _currentMainMenu.ReturnToMenuButton.onClick.RemoveListener(HideControllsUI);
        SceneManager.sceneLoaded -= UpdateCurrentUI;
    }

    private void UpdateCurrentUI(Scene scene, LoadSceneMode mode)
    {
        _currentMainMenu = UIManager.UIManagerInstance.CurrentMainMenu;

        _currentMainMenu.StartButton.onClick.AddListener(StartGame);
        _currentMainMenu.QuitButton.onClick.AddListener(QuitGame);
        _currentMainMenu.ControllsButton.onClick.AddListener(ShowControllsUI);
        _currentMainMenu.ReturnToMenuButton.onClick.AddListener(HideControllsUI);

        _currentMainMenu.StartButton.Select();
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void QuitGame()
    {
        Application.Quit();
    }

    private void ShowControllsUI() 
    {
        _currentMainMenu.ControllsPanel.SetActive(true);
        _currentMainMenu.ReturnToMenuButton.Select();
    }

    private void HideControllsUI()
    {
        _currentMainMenu.ControllsPanel.SetActive(false);
        _currentMainMenu.ControllsButton.Select();
    }

    public void ShowHideMenu(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (SceneManager.GetActiveScene().buildIndex >= 1)
            {
                EventSystem.current.SetSelectedGameObject(null);
                if (_currentMainMenu.gameObject.activeInHierarchy)
                {
                    _currentMainMenu.gameObject.SetActive(false);
                }
                else if (!_currentMainMenu.gameObject.activeInHierarchy)
                {
                    _currentMainMenu.gameObject.SetActive(true);
                    _currentMainMenu.StartButton.Select();
                }
            }
        }
    }
}
