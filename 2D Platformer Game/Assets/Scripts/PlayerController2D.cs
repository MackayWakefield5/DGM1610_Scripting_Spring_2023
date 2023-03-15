using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Header("PlayerStats")]

    // How fast the player is going to move
    public float speed;

    // How high the player will jump
    public float jumpForce;

    // get move input value
    private float moveInput; 

    // Player Ridgidbody
    [Header("Rigidbody Component")]

    private Rigidbody2D rb;

    private bool isFacingRight = true;

    // Player Jump
    [Header("Player Jump Settings")]

    private bool isGrounded = true;

    public Transform groundCheck;

    public float checkRadius;

    public LayerMask whatIsGround;

    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        // Get rigidbody component reference
        rb = GetComponent<Rigidbody2D>();  
    }

    // Fixed update is called a fixed or set number of frames. This works best with physics based movement
    void FixedUpdate()
    {
        // Check for ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        // Get the horizontal Keybinding which will return a value between -1 and 1
        moveInput = Input.GetAxis("Horizontal");

        // Move player left and right
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // If the player is moving right but facing left flip the player right
        if(!isFacingRight && moveInput > 0)
        {
            FlipPlayer();
        }

        // If the player is moving left but facing right flip the player left
        else if(isFacingRight && moveInput < 0)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;

        // Local Variable that store localscale value
        Vector3 scaler = transform.localScale;

        // Flip the sprit graphic
        scaler.x *= -1;

        transform.localScale = scaler;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            // Makes player jump
            rb.velocity = Vector2.up * jumpForce;

            doubleJump = false;
        }

        else if(Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            // Apply jumpForce to player making player jump
            rb.velocity = Vector2.up * jumpForce;
        }
    }
}
