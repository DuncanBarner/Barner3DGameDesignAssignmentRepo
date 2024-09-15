using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Duncan Barner
 * Prototype 2
 * Handles spawning of animals
 * 
 */
public class SpawnManager : MonoBehaviour
{
    //set this array of refs. in inspector

    public GameObject[] prefabsToSpawn;

    //variables for spawn position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPositionZ = 20;
    public HealthSystem healthSystem;
    void Start()
    {
        //get ref to healthsystem script
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);
        StartCoroutine(SpawnRandomPrefabCoroutine());


    }

    IEnumerator SpawnRandomPrefabCoroutine()
    {
        //add a 3 second delay before first spawn
        yield return new WaitForSeconds(3f);
        while (!healthSystem.gameOver)
        {
            SpawnRandomPrefab();
            float randomDelay = Random.Range(0.8f, 2.0f);
            yield return new WaitForSeconds(1.5f);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
        
    }

    void SpawnRandomPrefab()
    {
        //pick random animal
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPositionZ);

        //spawn animal
        Instantiate(prefabsToSpawn[prefabIndex], spawnPosition, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}
