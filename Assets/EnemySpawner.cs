using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemies;

    public float timeToSpawn;

    void Start()
    {

    }

    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0)
        {
            //we random wich enemy is spawned
            int randEnemy = Random.Range(0, enemies.Length);

            //We random the enemy's spawn
            int randSpawnPoint = Random.Range(0, spawnPoints.Length);

            //Create a random enemy at a random position
            Instantiate(enemies[0], spawnPoints[randSpawnPoint].position, transform.rotation);

            timeToSpawn = 1;
        }
    }
}
