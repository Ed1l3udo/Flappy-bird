    using Unity.VisualScripting;
    using UnityEditor.SearchService;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class GameManager : MonoBehaviour
    {
        public int points = 0;
        public int best = 0;
        public static GameManager Instance { get; private set; }
        void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void Play()
        {
            points = 0;
            Time.timeScale = 1f;
            SceneManager.LoadScene("PlayingScene");
        }

        public void GoToMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
