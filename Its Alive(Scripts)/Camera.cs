using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   
    public GameObject status,botoes, botaomov1,botaomov2,botaoCombate;
    public Animator trans_BTN, trans_BTN2;
    public Rigidbody2D rbc;
    public static int tela=2;
    bool tuto1, tuto2;
    public GameObject tuto01, tuto02;
    public static bool terminouTuto2=true;
   

    public void movecamera2()
    {
        if (terminouTuto2 == true)
        {
            if (tela == 2)
            {
                if (tuto1 == true)
                {
                    tuto01.SetActive(true);
                }

                rbc.velocity = new Vector2(-55, 0);

                tela = 1;
                botaomov1.SetActive(true);
                botaomov2.SetActive(false);
                GameManager.podeLutar = false;
                status.SetActive(true);
                botoes.SetActive(true);
            }
        } 
    }

   public void tuto1BTN()
    {
        terminouTuto2 = false;
        tuto01.SetActive(false);
        tuto1 = false;
        tuto2 = true;
    }

    public void tuto2BTN()
    {
        tuto02.SetActive(false);
        tuto2 = false;
    }
    public static bool terminouOtuto = false;

    public void movecamera()
    {
        if (terminouOtuto==true)
        {
            GameObject[] balaos2;

            balaos2 = GameObject.FindGameObjectsWithTag("balao");
            
            foreach (GameObject balao in balaos2)
            {
                Destroy(balao);
            }
            if (tela == 1)
            {
                if (tuto2 == true)
                {
                    tuto02.SetActive(true);
                }

                if (Scene_maneger.bodyCountPlayer > 0)
                {
                    GameManager.podeLutar = true;
                }

                rbc.velocity = new Vector2(55, 0);
                //  trans_BTN.SetTrigger("Normal");
                tela = 2;
                botaomov1.SetActive(false);
                botaomov2.SetActive(true);

                status.SetActive(false);
                botoes.SetActive(false);
            } 
       
        }
       
      
      //  transform.Translate(new Vector3);
    }
    void Start()
    {
        tuto1 = true;
        tuto2 = false;
        tela = 2;
       // swipe.x = +0.06f;
    }
   public static int contador;
   
    // Update is called once per frame
    void Update()
    {



      
        
       

      if (transform.position.x >= -0.03f)
        {
            transform.position = new Vector2(-0.29f, 0);
        }

        if (transform.position.x <= -14.90f)
        {
            transform.position = new Vector2(-14.80f, 0);
        }
    }
}
