using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutOfBounds : MonoBehaviour
{
    public Text textbox;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y > 80 || player.transform.position.y < -51)
        {
            textbox.text = "You Lose! \nPress R to Restart!";
        }
        
    }
}
