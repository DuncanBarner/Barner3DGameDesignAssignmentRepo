using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
 * Duncan Barner
 * Prototype 4
 * SpawnManager
 * Handles spawning of powerups/enemies and also win condition
 */

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 8;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerUp;
    public Text waveCounter;
    private bool allowSpawn = true;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber, allowSpawn);
        SpawnPowerup(1, allowSpawn);
    }

    private void SpawnEnemyWave(int enemiesToSpawn, bool allowSpawn)
    {
        if (allowSpawn == true)
        {
            for (int i = 0; i < enemiesToSpawn; i++)
            {
                //instantiate enemy in random position
                Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
            }
        }
    }

    private void SpawnPowerup(int powerupsToSpawn, bool allowSpawn)
    {
        if (allowSpawn == true)
        {
            for (int i = 0; i < powerupsToSpawn; i++)
            {
                //instantiate powerup in random position
                Instantiate(powerUp, GenerateSpawnPosition(), powerUp.transform.rotation);
            }
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        //generate random position on platform
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        if(enemyCount == 0 && allowSpawn == true)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber, allowSpawn);
            SpawnPowerup(1, allowSpawn);
        }
        waveCounter.text = "Wave: " + waveNumber;


        if(waveNumber == 10)
        {
            allowSpawn = false;
            if(enemyCount == 0)
            {
                waveCounter.text = "You Win! Press R to replay!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
        if(player.transform.position.y < -10)
        {
            allowSpawn = false;
            enemyCount = 0;
            waveCounter.text = "You Lose! Press R to retry!";
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


}
