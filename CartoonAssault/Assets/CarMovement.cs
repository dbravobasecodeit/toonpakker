﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public Vector2 jumpHeight;

    private bool isJumping = false;
    private float initialY;
    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D> ();
        initialY = rb2d.position.y;
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal") + 0.15f;

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis ("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.MovePosition(new Vector2 (rb2d.position.x + moveHorizontal, rb2d.position.y));

        if (moveVertical > 0 && !isJumping)
        {
            isJumping = true;
            rb2d.AddForce(new Vector2(0, 100), ForceMode2D.Impulse);
        }
        if ((rb2d.position.y > -3.9 || rb2d.position.y < -3.95) && isJumping)
        {
            isJumping = false;
        }
    }
}
