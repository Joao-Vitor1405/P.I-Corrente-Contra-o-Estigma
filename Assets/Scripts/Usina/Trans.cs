using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trans : MonoBehaviour
{
    public Renderer cor;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cor = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        Color c = cor.material.color;
        for (float alpha = 3f; alpha >= 0f; alpha -= 0.1f)
        {
            c.a = alpha;
            cor.material.color = c;
            yield return null;
        }

        Destroy(gameObject);
    }
}
