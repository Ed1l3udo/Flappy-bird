using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject counterPanel;
    public TextMeshProUGUI scoreText;
    public Button playAgainButton;
    public Button menuButton;

    void Start()
    {
        gameOverPanel.SetActive(false);
        counterPanel.SetActive(true);

        // remove todas as ações dos botões e atribui as corretas de novo
        playAgainButton.onClick.RemoveAllListeners();
        menuButton.onClick.RemoveAllListeners();

        playAgainButton.onClick.AddListener(GameManager.Instance.Play);
        menuButton.onClick.AddListener(GameManager.Instance.GoToMenu);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        counterPanel.SetActive(false);
        gameOverPanel.SetActive(true);
        scoreText.text = "Score: " + GameManager.Instance.points;
    }
    
}
