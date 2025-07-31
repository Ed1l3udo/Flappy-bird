using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce = 40f;
    [SerializeField] private UIManager uiManager;
    private Rigidbody2D rb;
    private bool jumpRequest = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpRequest = true;
        }
    }
    void FixedUpdate()
    {
        if (jumpRequest)
        {
            rb.linearVelocity = Vector2.up * jumpForce;
            jumpRequest = false;
        }
    }

    public void Die()
    {
        if(GameManager.Instance.best < GameManager.Instance.points)
        {
            GameManager.Instance.best = GameManager.Instance.points;
        }
        uiManager.GameOver();
    }

}
