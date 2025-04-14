using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    GameObject newEnemy;
    float timer;


    // if timer is less than 0, spawn enemy
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            SpawnEnemy();
            timer = spawnTimer;
        }
    }

    // generate spawn position based on spawn area
    void SpawnEnemy()
    {
        Vector3 position = new Vector3(
            UnityEngine.Random.Range(-spawnArea.x, spawnArea.x),
            UnityEngine.Random.Range(-spawnArea.y, spawnArea.y),
            0f
        );

        // assigns a position to the new enemy
        newEnemy = Instantiate(enemy);
        newEnemy.transform.position = position;

    }

    // destroy clones
    void Destroy()
    {
        DestroyImmediate(newEnemy);
    }


}
