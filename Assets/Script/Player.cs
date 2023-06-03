using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isJump=true;
    public Animator animation;
    public int health=1;
    Platform platform;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();

    }

    void Update()
    {
        if(isJump== false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(Vector2.up * jumpForce);
                isJump = true;
                animation.SetBool("Jump", true);
            }
        }
       
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Platform"))
        {
            isJump = false;
            animation.SetBool("Jump", false);
        }
        if(collision.gameObject.CompareTag("Enemy"))
        {
            health = 0;
            Platform.speed = 0;
           
            
        }

    }
}
