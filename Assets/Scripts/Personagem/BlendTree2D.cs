using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendTree2D : MonoBehaviour
{
    Animator anim;
    float velocityX = 0.0f;
    float velocityZ = 0.0f;
    public float acceleration = 2.0f;
    public float deceleration = 2.0f;
    int velocityXHash;
    int velocityZHash;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        velocityXHash = Animator.StringToHash("VelocityX");
        velocityZHash = Animator.StringToHash("VelocityZ");
    }

    // Update is called once per frame
    void Update()
    {
        bool wPressed = Input.GetKey("w");
        bool sPressed = Input.GetKey("s");//andar pra traz
        bool aPressed = Input.GetKey("a"); //esquerda
        bool dPressed = Input.GetKey("d"); //direita
        
        //andar/correr
        if (wPressed)
        {
            velocityZ = 0.5f;
            //velocityZ += Time.deltaTime * acceleration;
        }
        else
        {
            
        }
        if (sPressed)
        {
            velocityZ = -0.5f;
            //velocityZ -= Time.deltaTime * acceleration;
        }
        else
        {
           
        }
        //esquerda
        if (aPressed)
        {
            velocityX = -0.5f;
            //velocityX -= Time.deltaTime * acceleration;
        }
        else
        {
            
        }
        //direita
        if (dPressed)
        {
            velocityX = 0.5f;
            //transform.Rotate(0f, 180f, 0f);
            //velocityX += Time.deltaTime * acceleration;
        }
        else
        {
            
        }
        if (dPressed && sPressed)
        {
            velocityX = 0.5f;
            velocityZ = -0.4f;
            //transform.Rotate(0f, 180f, 0f);
            //velocityX += Time.deltaTime * acceleration;
        }
        else
        {
            

        }
        if (aPressed && sPressed)
        {
            velocityX = -0.5f;
            velocityZ = -0.4f;
            //transform.Rotate(0f, 180f, 0f);
            //velocityX += Time.deltaTime * acceleration;
        }
        else
        {
            

        }
        if (!wPressed && !sPressed && !aPressed && !dPressed) 
        {
            velocityX = 0f;
            velocityZ = 0f;
        }
        //atualiza parâmetros no unity
        anim.SetFloat(velocityXHash, velocityX);
        anim.SetFloat(velocityZHash, velocityZ);
    }
}
