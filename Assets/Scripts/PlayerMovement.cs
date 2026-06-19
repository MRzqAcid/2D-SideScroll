using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 3f;

    private Rigidbody2D rb;

    private SpriteRenderer spriteRenderer;
    void Start()
    {
        // ambil rigibody dari plauer
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    #region AnimationHandler
    private Animator animator;
    private void PlayWalk()
    {
        animator.SetTrigger("GoWalk");
    }
    private void PlayJump()
    {
        animator.SetTrigger("GoJump");
    }
    #endregion

    private void SpriteFlip(float horizontalInput)
    {
        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }
    }

    void Update()
    {

        // untuk menggerakan player ke kanan atau kiri
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f));
        SpriteFlip(horizontalInput);

        if (horizontalInput != 0) PlayWalk();

        bool isGrounded = Mathf.Abs(rb.linearVelocity.y) < 0.001f;
        // untuk loncat jika player nyentuh tanah
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            PlayJump();
        }
    }

    
}