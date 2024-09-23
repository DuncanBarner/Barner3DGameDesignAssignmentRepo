using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Duncan Barner
 * Prototype 1 
 * PlayerEnterTrigger
 * increments score by 1
 */

public class PlayerEnterTrigger : MonoBehaviour
{
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }

}
