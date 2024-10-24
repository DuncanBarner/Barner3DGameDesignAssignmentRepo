﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Pro3UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

    public Pro3PlayerController playerControllerScript;
    public bool won = false;


    // Start is called before the first frame update
    void Start()
    {
        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if(playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Pro3PlayerController>();
        }

        scoreText.text = "Score: 0";
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        if(playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to try again!";
        }

        if(score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;
            scoreText.text = "You Win!\nPress R to play again!";
        }
        if(playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
