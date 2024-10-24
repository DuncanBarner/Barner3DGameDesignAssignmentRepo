﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P3TriggerZoneAddScore : MonoBehaviour
{
    private Pro3UIManager uIManager;
    private bool triggered = false;


    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<Pro3UIManager>();
    }

  private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uIManager.score++;
        }
    }
}
