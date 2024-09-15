﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
		 * Duncan Barner
		 * PlaneScoreManager
		 * Challenge 1
		 * controls the score manager
		 */

public class PlaneScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
         gameOver = false;
         won = false;
         score = 0;

}

    // Update is called once per frame
    void Update()
    {
       //if game not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        
        //win condition 5 or more pts
        if(score >= 5)
        {
            won = true;
            gameOver = true;

        }
        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win! \nPress R to Restart!";
            }
            else
            {
                textbox.text = "You Lose! \nPress R to Restart!";
            }
        }
       
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}