using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Duncan Barner
 * Target.cs
 * Assignment 5B
 * Handles target object, player can shoot target and destroy it
 */

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void takeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            Die();
        }

        void Die()
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
