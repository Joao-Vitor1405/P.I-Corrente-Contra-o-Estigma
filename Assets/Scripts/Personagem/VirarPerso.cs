using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirarPerso : MonoBehaviour
{
    public float velocidade = 3.0f;
    public float jumpforce = 600f;
    public bool facingRight = true;
    public float moveX;
    private Rigidbody2D objeto;
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        objeto = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) 
        {
            animator.SetBool("Andando", true);
        }
        else
        {
            animator.SetBool("Andando", false);
        }
    }

    void FixedUpdate()
    {
        Mover();
        //PularPersonagem();
    }

    void Mover()
    {
       moveX = Input.GetAxis("Horizontal");
       if (moveX > 0 && !facingRight)
       {
       virarPersonagem();
       }
       else if (moveX < 0 && facingRight)
       {
       virarPersonagem();
       }
       objeto.linearVelocity = new Vector2(moveX * velocidade, objeto.linearVelocity.y);
    }
    void virarPersonagem()
    {
      facingRight = !facingRight;
      Vector3 scale =
      GetComponent<Transform>().localScale;
      scale.x *= -1;
      GetComponent<Transform>().localScale = scale;
    }

    //void PularPersonagem()
    //{
    // var absY = Mathf.Abs(objeto.velocity.y);
    //if (Input.GetKeyDown("space") && absY <= 0.05)
    //{
    // objeto.AddForce(new Vector2(objeto.velocity.x, jumpforce));
    //}
    
    //}
}
