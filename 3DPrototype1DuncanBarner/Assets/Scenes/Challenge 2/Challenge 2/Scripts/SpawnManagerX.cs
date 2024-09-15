using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Duncan Barner
 * Challenge 2
 * Spawns balls at random intervals at random x values
 * 
 */
public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;

    public Ch2HealthSystem healthSystem;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBall(Random.Range(minSpawnInterval, maxSpawnInterval)));

        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<Ch2HealthSystem>();
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall(float waitForSecond)
    {
        yield return new WaitForSeconds(waitForSecond);

        while (!healthSystem.gameOver)
        {
            // Generate random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            // Generate random ball index
            int ballIndex = Random.Range(0, ballPrefabs.Length);

            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

            yield return StartCoroutine(SpawnRandomBall(Random.Range(minSpawnInterval, maxSpawnInterval)));
        }
    }
}