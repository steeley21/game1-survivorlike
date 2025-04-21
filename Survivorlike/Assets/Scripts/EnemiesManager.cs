using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    [SerializeField] Transform player;
    GameObject newEnemy;
    float timer;


    private void Start()
    {
        timer = spawnTimer;
    }

    // if timer is less than 0, spawn enemy
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            SpawnEnemy();
            timer = spawnTimer;
        }
    }

    // generate spawn position based on spawn area
    void SpawnEnemy()
    {
        Vector3 center = player.position;
        float x = Random.Range(center.x - spawnArea.x, center.x + spawnArea.x);
        float y = Random.Range(center.y - spawnArea.y, center.y + spawnArea.y);
        Vector3 spawnPos = new Vector3(x, y, 0f);

        newEnemy = Instantiate(enemy);
        newEnemy.transform.position = spawnPos;

    }

    // destroy clones
    void Destroy()
    {
        DestroyImmediate(newEnemy);
    }


}
