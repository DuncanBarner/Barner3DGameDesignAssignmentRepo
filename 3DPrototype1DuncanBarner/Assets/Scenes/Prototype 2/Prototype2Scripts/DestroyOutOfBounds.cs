using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Duncan Barner
 * Prototype 2
 * Handles out of bounds animals and projectiles
 * 
 */

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    private HealthSystem healthSystemScript;

    private void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes OOB
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        
        //animals goes OOB
        if (transform.position.z < bottomBound)
        {
            //grab healthsystem script and call the take damage function
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}
