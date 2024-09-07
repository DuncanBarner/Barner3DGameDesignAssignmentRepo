using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
		 * Duncan Barner
		 * PlaneEnterTrigger
		 * Challenge 1
		 * increments score when player goes through trigger zones
		 */
public class PlaneEnterTrigger : MonoBehaviour
{
    public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            PlaneScoreManager.score++;
        }
    }
}
