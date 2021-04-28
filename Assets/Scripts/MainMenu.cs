using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;
    [SerializeField]
    private Button _quitButton;
    [SerializeField]
    private Button _controllsButton;
    [SerializeField]
    private Button _returnToMenuButton;
    [SerializeField]
    private GameObject _controllsPanel;

    public Button StartButton { get => _startButton; set => _startButton = value; }
    public Button QuitButton { get => _quitButton; set => _quitButton = value; }
    public Button ControllsButton { get => _controllsButton; set => _controllsButton = value; }
    public Button ReturnToMenuButton { get => _returnToMenuButton; set => _returnToMenuButton = value; }
    public GameObject ControllsPanel { get => _controllsPanel; set => _controllsPanel = value; }
}
