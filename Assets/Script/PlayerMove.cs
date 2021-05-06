using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    public float speed = 4.0f;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Input.GetAxis("Horizontal");

        var movement = new Vector2(direction, 0);

        rigidbody2D.velocity = movement * speed;

        if (direction > 0)
        {
            animator.SetBool("MoveRight", true);
            animator.SetBool("MoveLeft", false);

        }
        else if (direction < 0)
        {
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveLeft", true);
        }
        else
        {
            animator.SetBool("MoveRight", false);
            animator.SetBool("MoveLeft", false);
        }
    }
}
