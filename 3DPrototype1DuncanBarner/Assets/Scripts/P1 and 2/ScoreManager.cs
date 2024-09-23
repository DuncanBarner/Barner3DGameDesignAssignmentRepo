using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
 * Duncan Barner
 * Prototype 1 
 * ScoreManager
 * Score Manager Functionality
 */


public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    //set in inspector
    public Text textBox;


    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if game is not over, display score
        if (!gameOver)
        {
            textBox.text = "Score: " + score;

        }

        //if win condition is met
        if(score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textBox.text = "You win! \nPress R to Try Again!";

            }
            else
            {
                textBox.text = "You Lose! \nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

    }
}
