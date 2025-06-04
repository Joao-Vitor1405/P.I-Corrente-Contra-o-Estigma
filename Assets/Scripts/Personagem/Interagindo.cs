using UnityEngine;

public class Interagindo : MonoBehaviour
{
    public bool EstaInteragindo {  get; set; }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Interage"))
        {
            EstaInteragindo = true;
        }
        else
        {
            EstaInteragindo = false;
        }
    }
}
