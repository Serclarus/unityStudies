using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10;
    public float bound = 17;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -bound)
        {
            transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > bound)
        {
            transform.position = new Vector3(bound, transform.position.y, transform.position.z);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
    }
}
