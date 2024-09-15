using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/* 
 * Duncan Barner
 * Prototype 2
 * Displays score. If score >=5, player wins
 * 
 */
public class DisplayScore : MonoBehaviour
{
    public Text textbox;
    public int score = 0;
    public Text winbox;

    public GameObject winText;  // UI text to display when the player wins
    private bool hasWon = false;
    public HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        // Set the text component reference at the start
        textbox = GetComponent<Text>();
        textbox.text = "Score: 0";

        // Make sure the win message is hidden initially
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Update the score display
        textbox.text = "Score: " + score;

        // Check for win condition
        if (score >= 5 && !hasWon)
        {
            WinGame();
        }

        // Allow pressing "R" to restart the game
        if (hasWon && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart the scene
        }
    }

    void WinGame()
    {
        hasWon = true;  // Set the win flag
        winText.SetActive(true);  // Show the win message
        healthSystem.gameOver = true;
    }
}
