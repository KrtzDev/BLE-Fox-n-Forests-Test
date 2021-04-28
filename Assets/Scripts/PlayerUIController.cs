using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerUIController : MonoBehaviour
{
    [SerializeField]
    private ScriptableEvent<float> _coinAmountEvent;
    [SerializeField]
    private ScriptableEvent<float> _updateHealthUIEvent;

    [SerializeField]
    private ScriptableFloatObject _ownedCoins;

    private PlayerUI _currentPlayerUI;

    private void Awake()
    {
        _currentPlayerUI = UIManager.UIManagerInstance.CurrentPlayerMenu;
    }

    private void OnEnable()
    {
        _coinAmountEvent.Event += UpdateCoinUi;
        _updateHealthUIEvent.Event += UpdateHealthUI;
        SceneManager.sceneLoaded += UpdatePlayerUIRef;
    }

    private void OnDisable()
    {
        _coinAmountEvent.Event -= UpdateCoinUi;
        _updateHealthUIEvent.Event -= UpdateHealthUI;
        SceneManager.sceneLoaded -= UpdatePlayerUIRef;
    }

    private void UpdatePlayerUIRef(Scene scene, LoadSceneMode mode)
    {
        _currentPlayerUI = UIManager.UIManagerInstance.CurrentPlayerMenu;
        UpdateCoinUi(_ownedCoins.Value);
        UpdateHealthUI(50f);
    }

    private void UpdateCoinUi(float coinAmount)
    {
        if (_currentPlayerUI != null)
        {
            _currentPlayerUI.CoinText.text = "Coins: " + _ownedCoins.Value.ToString();
        }
    }
    private void UpdateHealthUI(float health)
    {
        if (_currentPlayerUI != null)
        {
            _currentPlayerUI.HealthText.text = "Health: " + health.ToString();
        }
    }
}
