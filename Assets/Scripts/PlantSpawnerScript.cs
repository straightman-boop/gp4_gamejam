using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSpawnerScript : MonoBehaviour
{
    public static PlantSpawnerScript plantSpawner;
    public int enemySpawnLimit;
    public GameObject barley;
    public GameObject wheat;
    public GameObject berries;
    public int blockSize = 20;
    public float xPosMax = 19f;
    public float xPosMin = -19f;
    public float yPosMax = 10f;
    public float yPosMin = -10f;
    float spawnInterval;

    public float duration = 10;
    float timer;
    bool spawned = false;

    private void Awake()
    {
        if (plantSpawner == null)
        {
            plantSpawner = this;
        }
        else if (plantSpawner != this)
        {
            Destroy(gameObject);
        }

    }
    private void Update()
    {
        if (spawned == false)
        {
            spawnBlock(1);
            spawned = true;
            timer = duration;
        }

        else if(spawned == true)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                spawned = false;
            }
        }

    }
    public void spawnBlock(int numberOfBlocks)
    {
        for (int i = 0; i < numberOfBlocks; i++)
        {
            Debug.Log(i);
            float spawnXPosition = Random.Range(xPosMin, xPosMax);
            float spawnYPosition = Random.Range(yPosMin, yPosMax);

            float chance = Random.Range(1, 10);

            if (chance <= 5)
            {
                GameObject block = Instantiate(wheat, new Vector2(spawnXPosition, spawnYPosition), Quaternion.identity);
            }

            else if (chance > 5 && chance <= 8)
            {
                GameObject block = Instantiate(barley, new Vector2(spawnXPosition, spawnYPosition), Quaternion.identity);
            }

            else
            {
                GameObject block = Instantiate(berries, new Vector2(spawnXPosition, spawnYPosition), Quaternion.identity);
            }


        }
    }
}
