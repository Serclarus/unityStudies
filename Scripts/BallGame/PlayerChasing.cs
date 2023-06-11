using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;

public class PlayerChasing : MonoBehaviour
{
    [SerializeField] float speed = 5;
    Rigidbody enemyRb;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
            player = GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(moveDirection * speed);

        if (transform.position.y < -4)
        {
            Destroy(gameObject);
        }

    }
}
