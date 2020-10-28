using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
   
    public void loadScene(string nome)
    {
        movimento.movimentoSpeed = -4;
        SceneManager.LoadScene(nome);
        PlayerControl.Derrota = false;
        PlayerControl.pontos = 0;
        Time.timeScale = 1;
        PlayerControl.Vitoria = false;
        PlayerControl.moveSpeed = 6;

      
    }
    public void sairJogo()
    {
        Application.Quit();


    }

}
