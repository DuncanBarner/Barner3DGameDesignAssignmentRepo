using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * Duncan Barner
 * WinTrigger.cs
 * Assignment 5B
 * Displays "You Win!" when the player enters the trigger zone
 */
public class WinTrigger : MonoBehaviour
{
    public Text winText;


    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.gameObject.SetActive(true);
        }
    }
}
