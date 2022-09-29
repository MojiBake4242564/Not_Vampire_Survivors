using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{

    public float move_speed = 10f;
    public Rigidbody2D rb;
    public Vector2 direction;
    // Update is called once per frame
    void Update()
    {
        // Player movement should be in Update because we want to 
        // check as often as possible for player input
        float move_x = Input.GetAxisRaw("Horizontal");
        float move_y = Input.GetAxisRaw("Vertical");

        // Setting direction to a new Vector2 with the x and y coordinates
        // This will be used later in the physics calculation 
        // Using this method both steps are needed to actually get the player moving 
        direction = new Vector2(move_x, move_y).normalized;
    }

    // This is for anything that doesn't need to be checked every frame. 
    private void FixedUpdate()
    {
        // Physics calculations
        // These don't need to be in update becaues we only need to calculate once
        rb.velocity = new Vector2(direction.x * move_speed, direction.y * move_speed);
    }
}

