using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public float startDelay = 2f;
    public float inteval = 1f;

    public GameObject[] animalPrefabs;
   

    //animal move from the top
    private float leftBound = -10f;
    private float rightBound = 10f;
    private float spawnPosZ = 18f;
    //animal move from the left
    private float upperBound = 15f;
    private float downBound = 5.5f;
    private float spawnPosXLeft = -18f;


    //animal move from the right
    private float spawnPosXRight = 18f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimalUp", startDelay, inteval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay, inteval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay, inteval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRandomAnimalUp()
    {
       
        Vector3 randomUpPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], randomUpPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        Vector3 randomLeftPos = new Vector3(spawnPosXLeft, 0, Random.Range(upperBound, downBound));
        //Rotation animal to the left
        Vector3 rotation = new Vector3(0, 90, 0);
        int animalIndex2 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex2], randomLeftPos, Quaternion.Euler(rotation));
    }
    void SpawnRandomAnimalRight()
    {
        Vector3 randomRightPos = new Vector3(spawnPosXRight, 0, Random.Range(upperBound, downBound));
        //Rotation animal to the left
        Vector3 rotation = new Vector3(0, -90, 0);
        int animalIndex3 = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex3], randomRightPos, Quaternion.Euler(rotation));
    }
}
