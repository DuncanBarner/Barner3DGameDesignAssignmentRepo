using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Duncan Barner
 * Challenge 2
 * Spawns dogs when user presses spacebar
 * 
 */

public class Ch2PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float dogSpawnTime; //to handle spamming

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dogSpawnTime - Time.time < -1) //prevents player from spamming the dog spawns
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                dogSpawnTime = Time.time;
            }

        }
    }
}
