﻿
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement Movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
            Movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
