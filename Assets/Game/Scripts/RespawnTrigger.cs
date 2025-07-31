using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    [SerializeField] private ObstaclesManager obstaclesManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            obstaclesManager.Respawn();
        }
    }
}
