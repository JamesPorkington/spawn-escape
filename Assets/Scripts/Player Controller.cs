using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D playerRb;

    public bool isOnGround = true;
    public float jumpForce = 10;
    public float cplayerStep = 0.015F;
    private float speed = 6;

    private float Move;
    private float MoveMomentum;
    private float maxSpeed = 20;

    private float jumpMomentum = 0;
    private float horizVel = 0;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        
    }


   

    void Update()
    {
        

        Move = Input.GetAxis("Horizontal");
        //MoveMomentum += 1;

        playerRb.velocity = new Vector2(speed * Move, playerRb.velocity.y);
        playerRb.AddForce(Vector2.right * Move * MoveMomentum, ForceMode2D.Impulse);

        jumpMomentum = 0;

        if (Input.GetAxis("Horizontal") != 0 && MoveMomentum < maxSpeed)
        {
            MoveMomentum += 0.01f;
        }
        else if (MoveMomentum == maxSpeed)
        {
            MoveMomentum = maxSpeed;
        }

        if (Input.GetAxis("Horizontal") == 0 && MoveMomentum > 0)
        {
            MoveMomentum -= 0.01f;
        }


        //if (Input.GetKeyDown(KeyCode.Space) && isOnGround && (!Input.GetKey(KeyCode.RightArrow)) && (!Input.GetKey(KeyCode.LeftArrow)))
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            horizVel = playerRb.velocity.x;
            horizVel = (horizVel * horizVel);
            horizVel = (horizVel / 150);
            //jumpMomentum += playerRb.velocity.x;
            jumpMomentum += horizVel;
            jumpMomentum += jumpForce;

            playerRb.AddForce(Vector2.up * jumpMomentum, ForceMode2D.Impulse);
            isOnGround = false;
            //jumpMomentum = 0;
            //horizVel = 0;
           
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            
        }
        else 
        {
            isOnGround = false;
        }
    }


}
