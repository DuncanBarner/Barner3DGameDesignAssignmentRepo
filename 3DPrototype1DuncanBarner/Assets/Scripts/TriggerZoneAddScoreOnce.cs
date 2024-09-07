using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Duncan Barner
 * Prototype 1 / Challenge 1
 * Increments score by 1 if triggerzone not previously triggered
 */


//Attach this to a trigger zone

public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
