using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    Vector3 spawnPoint = new Vector3(25, 0, 0);
    CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GameObject.Find("Player").GetComponent<CharacterController>();
        InvokeRepeating("SpawnObstacles", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacles()
    {
        if (characterController.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPoint, obstaclePrefab.transform.rotation);
        }
        
    }
}
