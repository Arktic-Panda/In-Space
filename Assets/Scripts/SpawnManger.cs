using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] asteroidPrefab;
    private float zRange = 30;
    public float spawnDelay;
    public float spawnInterval;
    
    // Start is called before the first frame update
    void Start()
    {   
        //Spawning animals with a delay and at intervals on launch
        InvokeRepeating("SpawnAsteroid", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Spawn Asteroid method
    void SpawnAsteroid()
    {
        //Setting X plane spawn positions in Array
        float [] laneNumber = new float [] {-5.5f,0,5.5f};
        //Generating Random spawn X postion
        System.Random random = new System.Random();
        float laneX = laneNumber[random.Next(0,laneNumber.Length)] ;
       
        //Spawning Random prefab of Asteroid
        int asteroidIndex = Random.Range(0, asteroidPrefab.Length);
        //Spawn Position
        Vector3 spawnPos = new Vector3(laneX, 0.7f, zRange);
        //Generating Prefab into scene
        Instantiate(asteroidPrefab[asteroidIndex], spawnPos, asteroidPrefab[asteroidIndex].transform.rotation);
    }  
    
}
