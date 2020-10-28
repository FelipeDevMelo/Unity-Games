using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UI : MonoBehaviour
{
    public static  Image barraLife;
    public Text txtVidro;
    public Text txtPapel;
    public Text txtPlastico;
    public Text txtMetal;
    public Text txtTempo;
    private float tempo;
    private float startTime;
    float t;
    


    private void Awake()
    {
        barraLife = GameObject.Find("barra").GetComponent<Image>();
       
    }
    private void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (t >=60f)
        {
           
            SceneManager.LoadScene("Vitoria");
        }

        if (barraLife.fillAmount == 1)
        {
          SceneManager.LoadScene("Derrota");
        }
         t = Time.time -startTime;
         tempo +=Time.deltaTime/60;
        string seconds = (t % 60).ToString("f1");
        txtTempo.text = seconds;
        txtMetal.text = Avatar.metal.ToString();
        txtVidro.text = Avatar.vidro.ToString();
        txtPapel.text = Avatar.papel.ToString();
        txtPlastico.text = Avatar.plastico.ToString();
 
   }

   
}
