using UnityEngine;

public class HPPlayer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetInteger("Walk", 1);
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetInteger("Walk", 0);
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animator.SetInteger("Walk", 2);
        } else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetInteger("Walk", 3);
        }
    }
}
