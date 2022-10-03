using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Generator : MonoBehaviour
{
    public const float PLAYER_DISTANCE = 200f;

    public Transform level_start;
    public Transform player;
    public Transform right;


    private void Update()
    {

        Vector3 offset = level_start.position + right.position;
        if (player.position.x >= 12) 
        {
            SpawnLevel(offset);
        }
    }

    private Transform SpawnLevel(Vector3 spawn_pos)
    {
        Transform level_part_transform = Instantiate(level_start, spawn_pos, Quaternion.identity);
        return level_part_transform;
    }

}
