using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detects mouse click or screen tap
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Implement game over logic here
        Time.timeScale = 0; // This will pause the game
        // Show Game Over UI
    }

}
