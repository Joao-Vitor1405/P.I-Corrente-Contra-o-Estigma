using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Canos : MonoBehaviour
{
    public bool c1,c2,c3,c4,c5,c6,c7 = false;
    public GameObject cano1;
    public GameObject cano2;
    public GameObject cano3;
    public GameObject cano4;
    public GameObject cano5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(c1 == true && c2 == true && c3 == true)
       {
            Debug.Log("passou");
       }

        if(cano1.transform.eulerAngles == new Vector3(0,0,0) || cano1.gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        {
            c1 = true;
        }
        else
        {
            c1 = false;
        }

        if (cano2.transform.eulerAngles == new Vector3(0, 0, 0) || cano2.gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        {
            c2 = true;
        }
        else
        {
            c2 = false;
        }
        
        if (cano3.transform.eulerAngles == new Vector3(0, 0, 90) || cano3.gameObject.transform.eulerAngles == new Vector3(0, 0, 270))
        {
            c3 = true;
        }
        else
        {
            c3 = false;
        }

        //if (cano4.transform.eulerAngles == new Vector3(0, 0, 0) || cano4.gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //{
        //    c4 = true;
        //}
        //else
        //{
        //    c4 = false;
        //}

        //if (cano5.transform.eulerAngles == new Vector3(0, 0, 0) || cano5.gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //{
        //    c5 = true; 
        //}
        //else
        //{
        //    c5 = false;
        //}


        //if (cano3.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //{

        //    c3 = true;
        //    Debug.Log("c1");
        //}
        //else
        //{
        //    c1 = false;
        //}

        //if (cano1.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //{

        //    c1 = true;
        //    Debug.Log("c1");
        //}
        //else
        //{
        //    c1 = false;
        //}


        //string nome = gameObject.name;
        //string partenome = nome.Substring(0, 9);

        //if (gameObject.transform.eulerAngles == new Vector3(0,0,0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180) 
        //    || gameObject.transform.eulerAngles == new Vector3(0, 0, -90) && partenome == "reto_0")
        //{
        //    Debug.Log("aq");
        //}
        //else
        //{
        //    Debug.Log("nada");
        //}

        //switch(partenome)
        //{
        //    case "reto_0(0)":
        //        if (gameObject.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //        {
        //           c1 = true;
        //            Debug.Log("c1");
        //        }
        //        else
        //        {
        //            c1 = false;
        //        }
        //        break;

        //    case "reto_0(1)":
        //        if (gameObject.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //        {
        //            c2 = true;
        //            Debug.Log(c2);
        //        }
        //        else
        //        {
        //            c2 = false;
        //        }
        //        break;

        //    case "reto_0(2)":
        //        if(gameObject.transform.eulerAngles == new Vector3(0, 0, 90) || gameObject.transform.eulerAngles == new Vector3(0, 0, -90))
        //        {
        //           c3 = true;
        //            Debug.Log(c3);
        //        }
        //        else
        //        {
        //            c3 = false;
        //        }
        //        break;

        //    case "reto_0(3)":
        //        if (gameObject.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180)) 
        //        {
        //            c4 = true;
        //            Debug.Log(c4);
        //        }
        //        else
        //        {
        //            c4 = false;
        //        }
        //        break;

        //    case "reto_0(4)":
        //        if (gameObject.transform.eulerAngles == new Vector3(0, 0, 0) || gameObject.transform.eulerAngles == new Vector3(0, 0, 180))
        //        {
        //            c5 = true;
        //            Debug.Log(c5);
        //        }
        //        else
        //        {
        //            c5 = false;
        //        }
        //        break;
        //}

        //if (c1 == true && c2 == true /*&& c3 == true && c4 == true && c5 == true*/)
        //{
        //    Debug.Log("passou");
        //}

        //if (c1 == true)
        //{
        //    Debug.Log("CONEXÃO ESTABELECIDA");
        //}
        //else 
        //{
        //    Debug.Log("djskadjk");
        //}
    }
   

    //private void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.CompareTag("Conexão2"))
    //    {
    //        Debug.Log("Tubulação 1 Conectada");
    //        c1 = true;
    //    }
    //    else
    //    {
    //        c1 = false;
    //    }
    //    if (col.CompareTag("Conexão3"))
    //    {
    //        Debug.Log("Tubulação 2 Conectada");
    //        c2 = true;
    //    }
    //    else if (col.CompareTag("Conexão 4"))
    //    {
    //        Debug.Log("Tubulação 3 Conectada");
    //        c3 = true;
    //    }
    //    else if (col.CompareTag("Conexão 5"))
    //    {
    //        Debug.Log("Tubulação 4 Conectada");
    //        c4 = true;
    //    }
    //    else if (col.CompareTag("Conexão 6"))
    //    {
    //        Debug.Log("Tubulação 5 Conectada");
    //        c5 = true;
    //    }
    //    else if (col.CompareTag("Conexão 7"))
    //    {
    //        Debug.Log("Tubulação 6 Conectada");
    //        c6 = true;
    //    }
    //    else if (col.CompareTag("Conexão 8"))
    //    {
    //        Debug.Log("Tubulação 7 Conectada");
    //        c7 = true;
    //    }

    //}
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Conexão1") || collision.gameObject.CompareTag("Conexão2"))
    //    {
    //        Debug.Log("Tubulação Conectada");
    //    }
    //}
}
