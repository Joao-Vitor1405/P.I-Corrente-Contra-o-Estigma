using UnityEngine;
using UnityEngine.SceneManagement;

public class PodeInteragir : MonoBehaviour
{
    public GameObject papel;
    public bool funciona = false;
    void Start()
    {
        
    }

    void Update()
    {    
        if (funciona && Input.GetButton("Interage"))
        {
            papel.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Colado"))
        {

            funciona = true;
    
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Colado"))
        {
            papel.SetActive(false);
        }
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    //if (col.tag == "Papel" && EstaInteragindo)
    //    //{
    //    //   painelPapel.SetActive(true);
    //    //}
    //    //if (col.tag == "Colado" && EstaInteragindo)
    //    //{
    //    //    SceneManager.LoadScene("DeslocamentoInicial");
    //    //}
    //    if (col.tag == "Familha" && EstaInteragindo)
    //    {
    //        Debug.Log("Entrou");
    //        GameObject mamar = Instantiate(papel, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    //    }



    //}
    private void FixedUpdate()
    {
        //if (Input.GetKeyUp(KeyCode.E))
        //{
        //    EstaInteragindo = true;
        //}
    }
    //////private void OnTriggerEnter2D(Collider2D col)
    //////{
    //////    if (col.tag == "Colado" && Input.GetKeyUp(KeyCode.E))
    //////    {
    //////        Debug.Log("Entrou");
    //////        papel.SetActive(true);
    //////    }
      
    //////}
    //void OnTrig(Collider2D coll)
    //{
    //    if (coll.tag == "Familha" && EstaInteragindo)
    //    {
    //        Debug.Log("Entrou");
    //        GameObject p = Instantiate(papel, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    //    }
    //}
}
