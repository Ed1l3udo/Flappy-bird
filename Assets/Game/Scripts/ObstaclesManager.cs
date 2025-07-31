using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public Vector3 respawnPos;
    public GameObject obstaclePrefab;

    void Start()
    {
        Instantiate(obstaclePrefab, respawnPos, Quaternion.identity);
    }

    public void Respawn()
    {
        Instantiate(obstaclePrefab, new Vector3 (respawnPos.x , Random.Range(-2.6f, 2.6f), 0), Quaternion.identity);
    }
}
