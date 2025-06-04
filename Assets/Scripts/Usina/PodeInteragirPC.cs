using UnityEngine;

public class PodeInteragirPC : MonoBehaviour
{
    public bool EstaInteragindo;
    public GameObject PC;
    public bool funciona = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (funciona && Input.GetButton("Interage"))
        {
            EstaInteragindo = true;
            Debug.Log("Entrou");
            PC.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("PC"))
        {

            funciona = true;

        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Colado"))
        {
            PC.SetActive(false);
        }
    }


}
