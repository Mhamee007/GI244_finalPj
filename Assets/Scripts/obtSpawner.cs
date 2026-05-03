using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;

    public Transform[] spawnPoints; 

    public float spawnDelay = 2f;

    void Start()
    {
        StartCoroutine(spawnLoop());
    }

    IEnumerator spawnLoop()
    {
        while (true)
        {
            spawnPattern();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    void spawnPattern()
    {
        int pattern = Random.Range(0, 6);

        switch (pattern)
        {
            case 0:
                spawnEnemy(0);
                break;

            case 1:
                spawnEnemy(1);
                break;

            case 2:
                spawnEnemy(2);
                break;

            case 3: 
                spawnEnemy(0);
                spawnEnemy(2);
                break;

            case 4:
                spawnEnemy(0);
                spawnEnemy(1);
                break;

            case 5: 
                spawnEnemy(0);
                spawnEnemy(1);
                spawnEnemy(2);
                break;
        }
    }

    

    void spawnEnemy(int index)
    {
        int randomIndex_enemy = Random.Range(0, enemyPrefab.Length);
        GameObject randomEnemy = enemyPrefab[randomIndex_enemy];
        Instantiate(randomEnemy, spawnPoints[index].position, Quaternion.identity);
    }
}