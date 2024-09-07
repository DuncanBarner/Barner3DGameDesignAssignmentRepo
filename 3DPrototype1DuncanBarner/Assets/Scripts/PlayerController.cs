using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Duncan Barner
 * Prototype 1 / Challenge 1
 * Player movement
 */

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float horizontalInput;
    public float forwardInput;
    public float turnSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


    }
}
