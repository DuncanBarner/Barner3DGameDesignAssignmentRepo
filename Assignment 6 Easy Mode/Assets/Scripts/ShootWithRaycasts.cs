using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Duncan Barner
 * ShootWithRaycasts.cs
 * Assignment 5B
 * Allows player to shoot objects with target script attached
 */
public class ShootWithRaycasts : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    private void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        { 
            //get the target script from the hit object
            Target target = hitInfo.transform.gameObject.GetComponent<Target>();
            //if target script was found, make target take damage
            if (target != null)
            {
                target.takeDamage(damage);

                if(hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }

        }
    }
}
