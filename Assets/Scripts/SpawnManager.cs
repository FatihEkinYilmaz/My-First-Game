using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;

    private float spawnRightX = 14;
    private float spawnLeftX = -8;
    private float SpawnRandomZ = 15;

    private float StartDelay = 2;
    private float spawnInterval = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", StartDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void SpawnRandomAnimal()
    {

        Vector3 RandomSpawn = new Vector3(Random.Range(spawnLeftX, spawnRightX), 1, SpawnRandomZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], RandomSpawn, carPrefabs[carIndex].transform.rotation);
    }
}
