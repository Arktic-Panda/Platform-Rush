using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Initializing Variables
    public float Speed = 0f;
    public float JumpSpeed = 0f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    // Find Rigid body component in game. can only work for rigid body applied sprites
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D> ();
    }

    // Setting Bool statements to control movement
    void Update()
    {
        movement = Input.GetAxis ("Horizontal");
        isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);

        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement*Speed, rigidBody.velocity.y);
            transform.localScale = new Vector2 (1f,1f);
        }
        else if (movement < 0f)
       {
             rigidBody.velocity = new Vector2(movement*Speed,rigidBody.velocity.y);
             transform.localScale = new Vector2 (-1f,1f);
       }

       if (Input.GetButtonDown ("Jump") && isTouchingGround)
       {
           rigidBody.velocity = new Vector2(rigidBody.velocity.x, JumpSpeed);
       }
    }
}
