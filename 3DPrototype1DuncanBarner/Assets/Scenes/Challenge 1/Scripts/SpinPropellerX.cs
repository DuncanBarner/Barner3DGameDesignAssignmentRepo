using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
		 * Duncan Barner
		 * SpinPropeller
		 * Challenge 1
		 * makes the propeller spin :)
		 */
public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed;
    void Update()
    {

        transform.Rotate(0,0,propellerSpeed *Time.deltaTime);
        
    }
}
