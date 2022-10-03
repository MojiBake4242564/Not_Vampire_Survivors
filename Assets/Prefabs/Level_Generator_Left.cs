using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generator_Left : MonoBehaviour
{
    public const float PLAYER_DISTANCE = 200f;

    public Transform level_start;
    public Transform player;
    public Transform left;
    public Transform right;


    private void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Vector3 spawn = player.position.normalized + left.position;
        Vector3 spawn = left.position.normalized + right.position;

        if (other.gameObject.tag == "Player")
        {
            SpawnLevel(spawn);
            //Debug.Log("I am going right");
        }


    }

    private void SpawnLevel(Vector3 spawn_pos)
    {
        Transform level_part_transform = Instantiate(level_start, spawn_pos, Quaternion.identity);
    }
}
