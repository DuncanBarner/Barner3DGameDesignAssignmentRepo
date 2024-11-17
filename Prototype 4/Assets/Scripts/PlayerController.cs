using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Duncan Barner
 * Prototype 4
 * PlayerController
 * Player movement
 */

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed;
    private float forwardInput;
    public bool hasPowerUp;
    private float powerUpStrength = 15.0f;
    public GameObject powerupIndicator;

    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");

        //move powerup indicator to ground below our player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            hasPowerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerUpCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerUpCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerUp = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerUp)
        {
            Debug.Log("Player collided with " + collision.gameObject.name + "with powerup " + hasPowerUp);

            //get local ref to enemy rb
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();

            //set Vector3 with direction away from player (knock them away)
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;

            //add impulse force away from player
            enemyRb.AddForce(awayFromPlayer * powerUpStrength, ForceMode.Impulse);
        }
    }

   
}
