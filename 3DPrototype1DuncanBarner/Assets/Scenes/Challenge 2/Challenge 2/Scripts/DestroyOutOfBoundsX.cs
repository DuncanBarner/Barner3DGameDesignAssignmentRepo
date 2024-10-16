﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Duncan Barner
 * Challenge 2
 * Destroys ball/dog if they go out of bounds
 * 
 */
public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<Ch2HealthSystem>().TakeDamage();
            Destroy(gameObject);
        }

    }
}
