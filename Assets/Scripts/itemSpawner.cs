using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour
{
    public GameObject speedBoostPrefab;
    public GameObject hpPotionPrefab;

    public List<GameObject> pool = new List<GameObject>();
    public int poolSize = 10;

    public float spawnDelay = 3f;
    public float itemLifeTime = 5f;

    public Vector2 xRange = new Vector2(-10f, 6f);
    public Vector2 zRange = new Vector2(80f, 150f);


    void Start()
    {

        for (int i = 0; i < poolSize; i++)
        {
            GameObject prefabToSpawn;
            int random = Random.Range(0, 100);

            if (random < 80)
            {
                prefabToSpawn = speedBoostPrefab;
            }
            else
            {
                prefabToSpawn = hpPotionPrefab;
            }

            GameObject obj = Instantiate(prefabToSpawn);

            obj.SetActive(false);

            pool.Add(obj);
        }

        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnItem();

            yield return new WaitForSeconds(spawnDelay);
        }
    }

    void SpawnItem()
    {
        GameObject prefabToSpawn;
        int random = Random.Range(0, 100);

        if (random < 80)
        {
            prefabToSpawn = speedBoostPrefab;
        }
        else
        {
            prefabToSpawn = hpPotionPrefab;
        }

        GameObject item = Instantiate(prefabToSpawn);

        float randomX = Random.Range(xRange.x, xRange.y);
        float randomZ = Random.Range(zRange.x, zRange.y);

        item.transform.position = new Vector3(randomX, 1, randomZ);

        StartCoroutine(DisableAfterTime(item));
    }

    IEnumerator DisableAfterTime(GameObject item)
    {
        yield return new WaitForSeconds(itemLifeTime);

        if (item != null)
        {
            Destroy(item);
        }
    }

}
