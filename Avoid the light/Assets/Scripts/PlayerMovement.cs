using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 10f;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private float dirx;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (dirx * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        UpdateAnimationPoint();
    }

    private void UpdateAnimationPoint()
    {
        if (dirx > 0f)
        {
            sprite.flipX = false;
        }
        else if (dirx < 0f)
        {
            sprite.flipX = true;
        }
        else
        {

        }
    }
}
