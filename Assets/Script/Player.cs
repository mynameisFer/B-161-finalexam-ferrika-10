using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private float moveSpeed = 5f;
   [SerializeField] private float jumpForce = 10f;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void SetMoveSpeed()
    {
        
    }

    private void SetInvulnerability()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
    }
}
