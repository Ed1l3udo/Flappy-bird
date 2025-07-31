using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public float respawnPosX;
    public Vector3 respawnPos;
    private bool needToRespawn;
    public GameObject obstaclePrefab;

    void Start()
    {
        respawnPos = new Vector3(respawnPosX, 0, 0);
    }

    void Update()
    {
        if (needToRespawn)
        {
            Instantiate(obstaclePrefab, respawnPos, Quaternion.identity);
        }
    }
    
}
