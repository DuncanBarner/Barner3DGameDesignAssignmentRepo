using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Duncan Barner
 * Prototype 2
 * Handles collision detection between animal and projectile
 * 
 */
public class DetectCollision : MonoBehaviour
{
    private DisplayScore displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
