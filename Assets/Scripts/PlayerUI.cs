using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _coinText;
    [SerializeField]
    private TMP_Text _HealthText;

    public TMP_Text CoinText { get => _coinText; set => _coinText = value; }
    public TMP_Text HealthText { get => _HealthText; set => _HealthText = value; }
}
