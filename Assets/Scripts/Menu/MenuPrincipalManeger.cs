using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManeger : MonoBehaviour
{
    
    [SerializeField]
    private string nomeDoLevelDeJogo;
    [SerializeField]
    private GameObject painelMenuInicial;
    [SerializeField]
    private GameObject painelOpcoes;

    public Transicao trans;
    public void Jogar()
    {
        trans.Transition("Sala");
    }

    public void AbrirOpções()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}
