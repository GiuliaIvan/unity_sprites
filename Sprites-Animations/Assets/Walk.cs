using UnityEngine;

public class Walk : MonoBehaviour
{   
    private Animator animator;
    private Vector3 moveDirection;
    public float moveSpeed = 3f;   
    void Start()
    {
        animator = GetComponent<Animator>();
        moveDirection = Vector3.zero; //Character starts stationary
    }

    // Update is called once per frame
    void Update()
    {
       HandleMovement();
    }

    void HandleMovement()
    {
        bool isMoving = false; // Track if movement is happening

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = Vector3.up;
            animator.SetInteger("Direction", 1);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection = Vector3.down;
            animator.SetInteger("Direction", 2);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection = Vector3.left;
            animator.SetInteger("Direction", 3);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.right;
            animator.SetInteger("Direction", 4);
            isMoving = true;
        }
        else
        {
            moveDirection = Vector3.zero;
        }

        // Move the character
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        // If moving, play animation at normal speed; otherwise, freeze it
        animator.speed = isMoving ? 1f : 0f;
    } 
}
