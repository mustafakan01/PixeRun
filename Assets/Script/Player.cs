using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isJump=true;
    public Animator animation;
    public bool death=false;
    Platform platform;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();

    }

    void FixedUpdate()
    {
        if(isJump== false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animation.SetBool("Jump", true);
                rb.AddForce(Vector2.up * jumpForce);
                isJump = true;
                
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
            //death = true;
            //Enemy.speed = 0;
            //Platform.speed = 0;
            //animation.SetBool("Death", true);
            Time.timeScale = 0;


        }

    }
}
