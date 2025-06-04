using UnityEngine;
using UnityEngine.SceneManagement;

public class PodeInteragirPorta : MonoBehaviour
{
    public string sceneName;
    public GameObject Porta;
    public bool funciona = false;
    public Transicao trans;

    // Update is called once per frame
    void Update()
    {
        if (funciona && Input.GetButton("Interage"))
        {
            SceneManager.LoadScene("Cena Casa");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Porta"))
        {

            funciona = true;

        }
    }
}
