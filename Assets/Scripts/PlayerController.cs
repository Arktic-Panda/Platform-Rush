using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
    public Vector3 respawnPoint;
    public GameManager gameLevelManager;

    // Find Rigid body component in game. can only work for rigid body applied sprites
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D> ();
        respawnPoint = transform.position;
        gameLevelManager = FindObjectOfType<GameManager> ();
    }

    // Setting Bool statements to control movement
    void Update()
    {
        movement = Input.GetAxis ("Horizontal");
        isTouchingGround = Physics2D.OverlapCircle (groundCheckPoint.position, groundCheckRadius, groundLayer);

        if (movement > 0f)
        {
            rigidBody.velocity = new Vector2(movement*Speed, rigidBody.velocity.y);
        }
        else if (movement < 0f)
       {
             rigidBody.velocity = new Vector2(movement*Speed,rigidBody.velocity.y);
       }

       if (Input.GetButtonDown ("Jump") && isTouchingGround)
       {
           rigidBody.velocity = new Vector2(rigidBody.velocity.x, JumpSpeed);
       }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Spike")
        {
           transform.position = respawnPoint;
        }
  
        if (other.tag == "Checkpoint")
        {
            respawnPoint = other.transform.position;
        }
    }
}
   
