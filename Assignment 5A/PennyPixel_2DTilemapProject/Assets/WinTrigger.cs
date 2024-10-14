using UnityEngine;
using UnityEngine.UI;

/*Duncan Barner
 * WinTrigger
 * Assignment 5A
 * Displays "You Win" when the player enters trigger zone @ end of level
 */

public class WinTrigger : MonoBehaviour
{
    [Header("References")]
    public Text winText; // Reference to the "You Win!" UI Text

    private void Start()
    {
        // Ensure the "You Win!" text is hidden at the start
        winText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the colliding object is the player
        if (other.CompareTag("Player"))
        {
            // Display the "You Win!" text
            winText.gameObject.SetActive(true);
        }
    }
}
