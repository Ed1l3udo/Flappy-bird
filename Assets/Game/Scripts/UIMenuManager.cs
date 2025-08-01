using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIMenuManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public Button playButton;
    public Button quitButton;

    void Start()
    {
        settingsPanel.SetActive(false);

        // remove todas as ações dos botões e atribui as corretas de novo
        playButton.onClick.RemoveAllListeners();
        quitButton.onClick.RemoveAllListeners();

        playButton.onClick.AddListener(GameManager.Instance.Play);
        quitButton.onClick.AddListener(GameManager.Instance.Quit);
    }

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
    }
    
}
