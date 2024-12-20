﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Duncan Barner
 * Prototype 4
 * EnemyAI
 * Enemy movement and behavior
 */
public class EnemyAI : MonoBehaviour
{

   private Rigidbody enemyRb;
   public GameObject player;
    public float speed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //add force toward the direction from the player to the enemy

        //vector for direction from enemy to player
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        //add force towards player
        enemyRb.AddForce(lookDirection * speed);
        
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
