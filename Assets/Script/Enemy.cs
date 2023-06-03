using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public  float speed = 5;
    float groundWitdh;
    public  Rigidbody2D rbe;
  
    void Start()
    {
        rbe = GetComponent<Rigidbody2D>();
        //groundWitdh = 30;
    }

    
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= groundWitdh)
        {
            transform.position = new Vector2(transform.position.x + 3 * groundWitdh, transform.position.y);
        }
    }
}
