using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private Ch2ScoreManager scoreManagerScript;
   
    private void Start()
    {
        scoreManagerScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<Ch2ScoreManager>();
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        scoreManagerScript.score++;
        
    }
}
