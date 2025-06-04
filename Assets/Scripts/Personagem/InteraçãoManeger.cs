using UnityEngine;

public class InteraçãoManeger : MonoBehaviour
{
    PodeInteragir interagir = new PodeInteragir();
    public GameObject papel;
    //[SerializeField] private GameObject painelPapel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Familha")
        {
            GameObject mama = Instantiate(papel, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
        //if (col.tag == "Colado" && EstaInteragindo)
        //{
        //    SceneManager.LoadScene("DeslocamentoInicial");
        //}
    }
}
