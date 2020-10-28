using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn_cobaias : MonoBehaviour
{
    public Text derota;
    public Animator anim;
    public Text cortinaTXT;
    public int fase;
    public GameObject[] cobaias;
    float currentTime , currentTime2, currentTime3;
    public float range, range2, range3;
    public AudioClip vuf,vitoria,derrota;
    AudioSource audioSource;
    public static int coounter;
   IEnumerator wait()
    {
        
        cortina.SetBool("iniciar_rodada", true);
        audioSource.PlayOneShot(vuf);
        yield return new WaitForSeconds(2.9f);
      
        cortina.SetBool("iniciar_rodada",false);
        anim.SetTrigger("Normal");
        audioSource.PlayOneShot(vuf);


    } 

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        fase = 1;
        contador = 0;
        cortina.SetBool("iniciar_rodada",true);
        StartCoroutine(wait());
        coounter = 1;
        GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
        TempPrefab.transform.position = new Vector3(400, -89, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
        
        GameManager.bodycount += 1;
       
    }

    public Animator cortina;
    int contador;
    // Update is called once per frame
    void Update()
    {
        cortinaTXT.text = "Rodada " + GameManager.rodada;
            if (GameManager.rodada == 2 && contador ==0 )
            {
            StartCoroutine(wait());
            coounter = 2;
            GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab2 = Instantiate(cobaias[0]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 1;
                contador += 1;
            
                GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
            {
                derota.text = "Vitoria";
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                {
                    
                    GameManager.energiaMax += 80;
                    GameManager.bateuNexusenemy = false;
                }

            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }
            GameManager.energiaAtual = GameManager.energiaMax;

            }
         
       
        if (GameManager.rodada == 3 && contador == 1)
        {

            StartCoroutine(wait());
            coounter = 1;
            GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab2 = Instantiate(cobaias[0]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[0]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
                  contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                    for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                derota.text = "Vitoria";
            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }

                GameManager.energiaAtual = GameManager.energiaMax;
            }

      
        if (GameManager.rodada == 4 && contador == 2)
        {
            StartCoroutine(wait());
            {
                coounter = 2;
                GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab2 = Instantiate(cobaias[0]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[1]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
                contador += 1;
                GameManager.podeLutar = false;
                if (GameManager.bateuNexusenemy == true)
                {
                    audioSource.PlayOneShot(vitoria);
                    for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                    derota.text = "Vitoria";
                }
                else
                {
                    derota.text = "Derrota";
                    audioSource.PlayOneShot(derrota);
                }
                GameManager.energiaAtual = GameManager.energiaMax;
            }
        }

        if (GameManager.rodada == 5 && contador == 3)
        {

            StartCoroutine(wait());
            coounter = 1;
            GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[1]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[1]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
            contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                derota.text = "Vitoria";
            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }

            GameManager.energiaAtual = GameManager.energiaMax;
            }
      
        if (GameManager.rodada == 6 && contador == 4)
        {
            StartCoroutine(wait());
            coounter = 2;
            GameObject TempPrefab = Instantiate(cobaias[2]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[1]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 1;
            contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                derota.text = "Vitoria";
            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }

            GameManager.energiaAtual = GameManager.energiaMax;
            

        }

        if (GameManager.rodada == 7 && contador ==5)
        {
            StartCoroutine(wait());
            coounter = 1;
            GameObject TempPrefab = Instantiate(cobaias[0]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[1]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[2]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
                contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                }
                derota.text = "Vitoria";






            } 
            else
                {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
                }
            GameManager.energiaAtual = GameManager.energiaMax;
        }

        if (GameManager.rodada == 8 && contador == 6)
        {
            StartCoroutine(wait());
            coounter = 2;
            GameObject TempPrefab = Instantiate(cobaias[1]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[2]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[2]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
            contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                }
                derota.text = "Vitoria";
            }
            else
                {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
                }

                GameManager.energiaAtual = GameManager.energiaMax;

            
        }

        if (GameManager.rodada == 9 && contador == 7)
        {
            StartCoroutine(wait());
            coounter = 1;
            GameObject TempPrefab = Instantiate(cobaias[1]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[2]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[3]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
            contador += 1;
            GameManager.podeLutar = false;
            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                derota.text = "Vitoria";
            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }

            GameManager.energiaAtual = GameManager.energiaMax;
            
        }

        if (GameManager.rodada == 10 && contador == 8)
        {
            StartCoroutine(wait());
            coounter = 2;
            GameObject TempPrefab = Instantiate(cobaias[3]) as GameObject;
                TempPrefab.transform.position = new Vector3(461, -89, 0);
                TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameObject TempPrefab2 = Instantiate(cobaias[3]) as GameObject;
                TempPrefab2.transform.position = new Vector3(370, -89, 0);
                TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);

                GameObject TempPrefab3 = Instantiate(cobaias[3]) as GameObject;
                TempPrefab3.transform.position = new Vector3(265, -89, 0);
                TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
                GameManager.bodycount += 2;
            contador += 1;
            GameManager.podeLutar = false;

            if (GameManager.bateuNexusenemy == true)
                {
                audioSource.PlayOneShot(vitoria);
                for (int e = 0; e < 1; e++)
                    {
                        GameManager.energiaMax += 80;
                        GameManager.bateuNexusenemy = false;
                    }
                derota.text = "Vitoria";
            }
            else
            {
                derota.text = "Derrota";
                audioSource.PlayOneShot(derrota);
            }

            GameManager.energiaAtual = GameManager.energiaMax;
            
        }
       
        /* GameObject TempPrefab2 = Instantiate(cobaias[1]) as GameObject;
         TempPrefab2.transform.position = new Vector3(589, -89, 0);
         TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);








         GameObject TempPrefab3 = Instantiate(cobaias[2]) as GameObject;
         TempPrefab3.transform.position = new Vector3(589, -89, 0);
         TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);*/



    }
}
