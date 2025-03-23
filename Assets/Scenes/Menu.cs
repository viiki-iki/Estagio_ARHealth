using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Menu1;
    //public GameObject Direita;
   // public GameObject Esquerda;
    public GameObject Panel;
    public Animator transicao;
    // public Animation aparecendo;
    public GameObject imagem;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Sim());
    }
    IEnumerator Sim()
    {
        // Direita.SetActive(false);
       // Esquerda.SetActive(false);
        Menu1.SetActive(false);
        Panel.SetActive(true);
        imagem.SetActive(false);

        transicao.SetBool("Inicio", true);
        Menu1.SetActive(true);
        yield return new WaitForSeconds(0.8f);
        imagem.SetActive(true);
        yield return new WaitForSeconds(0.2f);

        transicao.SetBool("Inicio", false);
        Panel.SetActive(false);
    }

    public void Iniciar()
    {
        StartCoroutine(LoadScene());
        //SceneManager.LoadScene(1);
    }
    IEnumerator LoadScene()
    {
        Panel.SetActive(true);
        transicao.SetBool("End", true);
        yield return new WaitForSeconds(1f);
        transicao.SetBool("End", false);
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
