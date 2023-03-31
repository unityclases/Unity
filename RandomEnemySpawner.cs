using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnemySpawner : MonoBehaviour
{
    public GameObject[] enemies; // Array de enemigos

    public float spawnInterval = 5f; // Intervalo de tiempo entre cada spawn
    private float nextSpawnTime;

    private void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            // Selecciona un enemigo aleatorio del array
            GameObject randomEnemy = enemies[Random.Range(0, enemies.Length)];

            // Crea una instancia del enemigo en una posición aleatoria
            Vector3 spawnPosition = new Vector3(0,0,0);
            Instantiate(randomEnemy, spawnPosition, Quaternion.identity);

            // Establece el tiempo para el siguiente spawn
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}
