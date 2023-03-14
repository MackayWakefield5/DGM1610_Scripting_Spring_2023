using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    // Array to store UFO Ships
    public GameObject[] ufoPrefabs;

    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomUFO();
        }
    }

    void SpawnRandomUFO()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);

        // Picks a random UFO from the array
        int ufoIndex = Random.Range(0,ufoPrefabs.Length);

        // Spawns indexed UFO from array, a random location on th X-Axis
        Instantiate(ufoPrefabs[ufoIndex],spawnPos,ufoPrefabs[ufoIndex].transform.rotation);
    }
}
