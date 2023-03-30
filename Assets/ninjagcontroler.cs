using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ninjagcontroler : MonoBehaviour
{
     Animator animator;
    Rigidbody2D rb;
    SpriteRenderer sr;
    private int currentAnimation = 1;

    void Start()
    {
        animator = GetComponent<Animator>(); 
       rb = GetComponent<Rigidbody2D>(); 
       sr = GetComponent<SpriteRenderer>(); 
    }
    void Update()
    {
        currentAnimation = 1;
        var velocityY = rb.velocity.y;
        rb.velocity = new Vector2(0, velocityY);

        //Run
        if(Input.GetKey(KeyCode.RightArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(10,velocityY);
            sr.flipX = false;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(-10,velocityY);
            sr.flipX = true;
        }
        //Deslisar
         if(Input.GetKey(KeyCode.C))
        {
            currentAnimation = 3;
            rb.velocity = new Vector2(-10,velocityY);
            sr.flipX = true;
        }
        if(Input.GetKey(KeyCode.V))
        {
            currentAnimation = 3;
            rb.velocity = new Vector2(10,velocityY);
            sr.flipX = false;
        }
        //Lanzar
        if(Input.GetKey(KeyCode.X))
        {
            currentAnimation = 4;
        }
        //Atacar
        if(Input.GetKey(KeyCode.Z))
        {
            currentAnimation = 5;
        }
      //Dead
        if(Input.GetKey(KeyCode.D))
        {
            currentAnimation = 6;
        }
        animator.SetInteger("Estado",currentAnimation);
    }
}
