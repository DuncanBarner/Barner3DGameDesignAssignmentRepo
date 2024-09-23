using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pro3MoveLeft : MonoBehaviour
{

    public float speed;
    private float leftBound = -15f;
    private Pro3PlayerController playerControllerScript;
    
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<Pro3PlayerController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
        
    }
}
