using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float deadZone = -10f;

    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
