using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxCurrency : MonoBehaviour
{
    [SerializeField]
    private ScriptableFloatObject _ownedCoins;
    [SerializeField]
    private ScriptableEvent<float> _sendCoinAmountEvent;


    private float _coins = 0;

    public void AddToCoinsOwned(float coinAmount)
    {
        _coins += coinAmount;
        _ownedCoins.Value = _coins;
        _sendCoinAmountEvent.Raise(_coins);
    }
}
