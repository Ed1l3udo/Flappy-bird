using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI  pointsText;
    [SerializeField] private TextMeshProUGUI bestText;
    void Start()
    {
        pointsText.text = "Points: " + 0;
        bestText.text = "Best: " + GameManager.Instance.best;
    }

    void Update()
    {
        pointsText.text = "Points: " + GameManager.Instance.points;
    }
}
