using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Duncan Barner
 * Prototype 1 / Challenge 1
 * Camera follow player script
 */

public class CamFollowPlayer : MonoBehaviour
{
    //drag the player onto this ref
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
