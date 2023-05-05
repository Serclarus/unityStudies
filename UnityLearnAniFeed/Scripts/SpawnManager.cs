using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-17, 17), 0, 30), animalPrefabs[animalIndex].transform.rotation);
    }
}
