using UnityEngine;
using UnityEngine.UI;

/*Duncan Barner
 * ScoreManager
 * Assignment 5A
 * Handles score functions
 */

public class ScoreManager : MonoBehaviour
{
    public static int score = 0; // The player's score
    public Text scoreText; // UI Text element to display the score

    private void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
