using UnityEngine;

public class check : MonoBehaviour
{
    Rigidbody2D rb;
    int[] angulos = { 0, 90, 180, 270 };
    int rotação = 90;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int sorteio = Random.Range(0, angulos.Length);
        transform.eulerAngles = new Vector3(0, 0, angulos[sorteio]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //rotação = +90;
        transform.Rotate(new Vector3(0, 0, 90));
        Debug.Log("sjf");
    }
}
