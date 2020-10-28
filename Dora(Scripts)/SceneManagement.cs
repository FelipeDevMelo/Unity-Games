using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void Iniciar()
    {
        StartCoroutine(Esperar());
       
    }
    public void MudarScene(string cena)
    {
        
        SceneManager.LoadScene(cena);
    }
    public void sair()
    {
        SoundManager.PlaySom("Button");
        Application.Quit();
    }
    IEnumerator Esperar()
    {
        SoundManager.PlaySom("Button");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Teste");
    }
}
