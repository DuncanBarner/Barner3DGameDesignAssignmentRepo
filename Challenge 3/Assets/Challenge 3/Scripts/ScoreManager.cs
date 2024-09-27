using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
		 Duncan Barner
		 ScoreManager
		 Challenge 3
		 Manages score on UI, press R to restart
		 */



public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    public Text textbox;
    public PlayerControllerX playerController;
    public bool won = false;

    // Update is called once per frame
    void Start()
    {
        textbox.text = "Score: ";
    }
    void Update()
    {
        if (!playerController.gameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (playerController.gameOver && !won) {
            textbox.text = "You Lose! \nPress R to Try Again!";

        }

        if(score >= 10)
        {
            playerController.gameOver = true;
            won = true;
            textbox.text = "You Win! \nPress R to Play Again!";
        }

        if (playerController.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("R Key Pressed");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
