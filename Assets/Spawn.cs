using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnDelay = 1.0f; // Delay between spawns, in seconds
    float spawnTimer = 0.0f; // Timer for spawning enemies

    void SpawnEnemy()
    {
        float minX = -8; // Minimum X position for spawning
        float maxX = 8; // Maximum X position for spawning
        float minY = 6; // Minimum Y position for spawning
        float maxY = 6; // Maximum Y position for spawning

        float spawnX = Random.Range(minX, maxX); // Choose a random X position
        float spawnY = Random.Range(minY, maxY); // Choose a random Y position
        Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0); // Set the spawn position
        Quaternion spawnRotation = Quaternion.identity; // Use default rotation
        Instantiate(enemyPrefab, spawnPosition, spawnRotation);
    }


    void Update()
    {
        // Increment the spawn timer
        spawnTimer += Time.deltaTime;

        // If the spawn timer has reached the spawn delay, spawn an enemy
        if (spawnTimer >= spawnDelay)
        {
            SpawnEnemy();
            spawnTimer = 0.0f; // Reset the spawn timer
        }
    }
}
