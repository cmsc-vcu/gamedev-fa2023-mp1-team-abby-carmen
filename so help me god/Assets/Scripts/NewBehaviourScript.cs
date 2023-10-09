using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewBehaviourScript : MonoBehaviour
{ 
    [SerializeField] private float speed = 5;

    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }


        if (movement.x > 0)
        {
            rb.transform.localScale = new Vector3(6, 6, 1);
        }

        if (movement.x < 0)
        {
            rb.transform.localScale = new Vector3(-6, 6, 1);
        }

    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        if (movement.x != 0 || movement.y != 0)
        {
            rb.velocity = movement * speed;
        }
    }
}

