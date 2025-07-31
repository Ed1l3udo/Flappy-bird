using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Destroy(other.transform.root.gameObject);
        }   
    }
}
