using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Duncan Barner
 * GemBehavior
 * Assignment 5A
 * Edited the prefab script to allow for score incrementing
 */

public class GemBehaviour : MonoBehaviour
{
    [Header("References")]
    public GameObject gemVisuals;
    public GameObject collectedParticleSystem;
    public CircleCollider2D gemCollider2D;

    [Header("Scoring")]
    public int gemValue = 1; // Value of the gem

    private float durationOfCollectedParticleSystem;

    void Start()
    {
        durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;
    }

    void OnTriggerEnter2D(Collider2D theCollider)
    {
        if (theCollider.CompareTag("Player"))
        {
            GemCollected();
        }
    }

    void GemCollected()
    {
        // Disable the gem visuals and collider
        gemCollider2D.enabled = false;
        gemVisuals.SetActive(false);
        collectedParticleSystem.SetActive(true);

        // Find the ScoreManager and increment the score
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.AddScore(gemValue); // Add the gem's value to the score
        }

        // Deactivate the gem object after particle system duration
        Invoke("DeactivateGemGameObject", durationOfCollectedParticleSystem);
    }

    void DeactivateGemGameObject()
    {
        gameObject.SetActive(false);
    }
}
