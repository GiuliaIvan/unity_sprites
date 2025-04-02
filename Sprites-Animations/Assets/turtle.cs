using UnityEngine;

public class Turtle : MonoBehaviour
{
    private Animator animator;
    private float moveSpeed = 5f; // Define move speed

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        bool isMoving = false; // Track movement to update animation

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x -= moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 1); // Set walking animation
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x += moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 2); // Set walking animation
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y += moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 3); // Set walking animation
            isMoving = true;
        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.y -= moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 4); // Set walking animation
            isMoving = true;
        }

        transform.position = newPosition;
    }
}