using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour

{
    
    public Light luzinha;
    public Image BarraLife;
    public Transform camTransform;
    
   
   
    public GameObject exp;
   
    void Start()
    {
       

          
    }

   
    void Update()
    {
        if (BarraLife.fillAmount == 1)
        {
            PlayerControl.Derrota = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "CArro":
                Destroy(gameObject);
                GameObject tempPrefb = Instantiate(exp) as GameObject;
                tempPrefb.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                PlayerControl.Derrota = true;
                PlayerControl.moedas += PlayerControl.pontos;
                break;
            case "DrinkRed":
                Time.timeScale += 0.5f;
                BarraLife.fillAmount += 0.20f;
                break;

            case "DrinkBlue":
                PlayerControl.moveSpeed -= 1.5f;
                BarraLife.fillAmount += 0.20f;
                break;
            case "DrinkRoxo":
                luzinha.intensity -= 0.5f;
                StartCoroutine(DrinkRoxo(0.2f));
               
                BarraLife.fillAmount += 0.20f;
                break;
            case "DrinkMorte":
                StartCoroutine(DrinkMorte(1));
                BarraLife.fillAmount += 0.40f;
                break;

            case "Chegada":
                PlayerControl.Vitoria = true;
                PlayerControl.moedas += PlayerControl.pontos;
                break;




        }

    }
    
   
    IEnumerator DrinkRoxo(float tempo)
    {
        luzinha.color = Color.red;
        yield return new WaitForSeconds(tempo);
        luzinha.color = Color.blue;
        yield return new WaitForSeconds(tempo);
        luzinha.color = Color.green;
        yield return new WaitForSeconds(tempo);
        luzinha.color = Color.white;

    }
    IEnumerator DrinkMorte(float Tempo)
    {
        camTransform.transform.eulerAngles = new Vector3(0, 0, -180);
        yield return new WaitForSeconds(Tempo);
        camTransform.transform.eulerAngles = new Vector3(0, 0, 0);
    }
   

   
}
