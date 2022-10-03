using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player;
    public Rigidbody2D rb;
    public Vector2 move;
    public float move_speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Track player coordinates
        Vector2 direction = player.position - transform.position;
        direction.Normalize();
        move = direction;


    }

    private void OnTriggerStay2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
            Debug.Log("I hate everyone!");

    }

    private void FixedUpdate()
    {
        MoveEnemy(move);
    }

    void MoveEnemy(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * move_speed * Time.deltaTime));
    }
}
