using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    CharacterController characterControllerScript;
    public float speed = 10;
    float bound = -7;
    // Start is called before the first frame update
    void Start()
    {
        // Finds the CharacterController script in player
        characterControllerScript = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Makes objects move to the left
        if (characterControllerScript.gameOver == false)
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        if (gameObject.transform.position.x < bound && gameObject.CompareTag("Obstacle")) 
        {
            Destroy(gameObject);
        }
        
    }
}
