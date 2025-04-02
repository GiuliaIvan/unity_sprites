using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;

    [Header("-- Private references --")]
    [SerializeField] private int coinsCollected = 0;

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component
    }

    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        bool isMoving = false; // Track movement to update animation

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            newPosition.x -= moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 1); // Set walking animation
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            newPosition.x += moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 2); // Set walking animation
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            newPosition.y += moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 3); // Set walking animation
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            newPosition.y -= moveSpeed * Time.deltaTime;
            animator.SetInteger("Walk", 4); // Set walking animation
            isMoving = true;
        }

        if (!isMoving) {
            animator.SetInteger("Walk", 0); // Stop animation when idle
        }

        transform.position = newPosition;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Coin")) {
            coinsCollected += 1;
            Destroy(coll.gameObject);
        }
    }
}
