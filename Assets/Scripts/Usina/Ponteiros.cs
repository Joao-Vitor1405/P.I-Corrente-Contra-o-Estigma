using UnityEngine;
using UnityEngine.UI;



public class Ponteiros : MonoBehaviour
{
    public Slider sli;
    public Slider sli2;
    public Slider sli3;
    public GameObject btn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sli.value == 1f && sli2.value == 1f && sli3.value == 1f)
        {
            btn.SetActive(true);
        }
    }
}
