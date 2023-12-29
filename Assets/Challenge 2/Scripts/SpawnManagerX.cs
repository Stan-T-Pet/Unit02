using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using URandom = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        // Set the initial spawnInterval value
        spawnInterval = URandom.Range(2, 4);

        // Invoke the SpawnRandomBall method with repeating interval
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    //Spawn random ball at random x position at the top of the play area
    void SpawnRandomBall()
    {
        // Update spawnInterval for the next invocation
        spawnInterval = URandom.Range(2, 4);

        // Making an index for balls to create a random range for the random spawn location
        int ballSpawnIndex = URandom.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(URandom.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballSpawnIndex], spawnPos, ballPrefabs[ballSpawnIndex].transform.rotation);
    }
}
