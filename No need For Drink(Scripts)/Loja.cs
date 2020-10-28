using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loja : MonoBehaviour
{
   
    public GameObject comprar1, comprar2, usar1, usar2, tirar1, tirar2;
    public UnityEngine.UI.Text MoedasTXT;
    void Start()
    {
       
    }

    public void compraSkin1()
    {
        if (PlayerControl.moedas>= 50)
        {
            PlayerControl.moedas -= 50;
            PlayerControl.comprado1 = true;
            comprar1.SetActive(false);
            usar1.SetActive(true);
        }
       
        
    }
    public void usarSkin1()
    {
        PlayerControl.verificadordeSkin = "Skin1";
        usar1.SetActive(false);
        tirar1.SetActive(true);
    }
    public void tiraSkin1()
    {
        PlayerControl.verificadordeSkin = "Idle";
        tirar1.SetActive(false);
        usar1.SetActive(true);
    }
    public void compraSkin2()
    {
        
        if (PlayerControl.moedas >= 50)
        {
            PlayerControl.moedas -= 50;
            PlayerControl.comprado2 = true;
            comprar2.SetActive(false);
            usar2.SetActive(true);
        }


    }
    public void usarSkin2()
    {
        PlayerControl.verificadordeSkin = "Skin2";
        usar2.SetActive(false);
        tirar2.SetActive(true);
    }
    public void tiraSkin2()
    {
        PlayerControl.verificadordeSkin = "Idle";
        tirar2.SetActive(false);
        usar2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControl.comprado1==true)
        {
            comprar1.SetActive(false);
            usar1.SetActive(true);
        }
        if (PlayerControl.comprado2==true)
        {
            comprar2.SetActive(false);
            usar1.SetActive(true);
        }
        MoedasTXT.text = "moedas : " + PlayerControl.moedas.ToString();
    }
}
