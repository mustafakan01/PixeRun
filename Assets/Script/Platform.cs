using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed=5;
    BoxCollider2D box;
    float groundWitdh;



    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        groundWitdh = box.size.x;
           
    }
    void Update()
    {
       transform.position = new Vector2(transform.position.x-speed*Time.deltaTime, transform.position.y);

        if (transform.position.x<=groundWitdh)
        {
            transform.position = new Vector2(transform.position.x +3* groundWitdh, transform.position.y);
        }

    }
}
