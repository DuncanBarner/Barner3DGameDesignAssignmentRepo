using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* 
 * Duncan Barner
 * Challenge 2
 * Displays score. If score >=5, player wins
 * 
 */

public class Ch2ScoreManager : MonoBehaviour
{
    public Text textbox;
    public int score = 0;

   // public Text winbox;
    public GameObject winText;// when player wins

    public Ch2HealthSystem healthForGameOver;

    bool hasWon = false;


    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";

        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
        if (score >= 5 && !hasWon)
        {
            WinGame();
        }

        if (hasWon && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the scene
        }

        void WinGame()
        {
            hasWon = true;  // Set the win flag
            winText.SetActive(true);  // Show the win message
            healthForGameOver.gameOver = true;
        }
    }
}
