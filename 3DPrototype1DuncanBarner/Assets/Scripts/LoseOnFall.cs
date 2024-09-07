using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Duncan Barner
 * Prototype 1 / Challenge 1
 * Game over condition (player falls off the road)
 */

public class LoseOnFall : MonoBehaviour
{
    // attach to player
    public Text textBox;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameOver = true;
        }


    }
}
