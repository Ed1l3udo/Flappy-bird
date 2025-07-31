using UnityEngine;

public class InfiniteRollingg : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float resetX;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.left);
        if (transform.position.x <= -resetX)
        {
            transform.position = new Vector3(resetX, 0, 0);
        }
    }
}
