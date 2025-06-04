using UnityEngine;
using UnityEngine.SceneManagement;

public class PortaUsina : MonoBehaviour
{

    public bool EstaInteragindo;
    public GameObject Porta;
    public bool funciona = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (funciona && Input.GetButton("Interage"))
        {
            EstaInteragindo = true;
            SceneManager.LoadScene("Bla");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PortaUsina"))
        {

            funciona = true;

        }
    }
}
