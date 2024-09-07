using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed;
    void Update()
    {

        transform.Rotate(0,0,propellerSpeed *Time.deltaTime);
        
    }
}
