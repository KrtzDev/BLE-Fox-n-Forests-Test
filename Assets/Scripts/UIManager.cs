using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private static UIManager _uiManagerInstance;

    [SerializeField]
    private MainMenu _mainMenuPrefab;
    [SerializeField]
    private PlayerUI _playerUIPrefab;

    [SerializeField]
    private ScriptableFloatObject _ownedCoins;

    private MainMenu _currentMainMenu;
    private PlayerUI _currentPlayerUI;

    public static UIManager UIManagerInstance { get { return _uiManagerInstance; } }

    public MainMenu CurrentMainMenu { get => _currentMainMenu; set => _currentMainMenu = value; }
    public PlayerUI CurrentPlayerMenu { get => _currentPlayerUI; set => _currentPlayerUI = value; }

    private void Awake()
    {
        if (_uiManagerInstance != null && _uiManagerInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        _uiManagerInstance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SpawnUI;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= SpawnUI;
    }

    private void SpawnUI(Scene scene, LoadSceneMode mode)
    {
        _currentMainMenu = Instantiate(_mainMenuPrefab);
        if (scene.buildIndex >= 1)
        {
            _currentMainMenu.gameObject.SetActive(false);
            _currentPlayerUI = Instantiate(_playerUIPrefab);
        }
        if (scene.buildIndex == 1)
        {
            _ownedCoins.Value = 0;
            _currentPlayerUI.CoinText.text = _ownedCoins.Value.ToString();
        }
    }

}
