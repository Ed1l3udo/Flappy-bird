using Unity.VisualScripting;
using UnityEngine;

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
}
