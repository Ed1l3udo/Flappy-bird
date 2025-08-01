using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    public Button playButton;
    public Button quitButton;

    void Start()
    {

        // remove todas as ações dos botões e atribui as corretas de novo
        playButton.onClick.RemoveAllListeners();
        quitButton.onClick.RemoveAllListeners();

        playButton.onClick.AddListener(GameManager.Instance.Play);
        quitButton.onClick.AddListener(GameManager.Instance.Quit);
    }
}
