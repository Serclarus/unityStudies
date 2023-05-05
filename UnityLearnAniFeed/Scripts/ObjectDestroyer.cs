using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    float bound = 35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -bound || transform.position.z > bound)
        {
            Destroy(gameObject);
        }
    }
}
