using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentoGato : MonoBehaviour
{

    public Image imgEnergia;//  barra de energia
    public float jumpForce;//força do pulo do gato
    private Rigidbody2D rbCat;// rigidBody2d do gato

    void Start()
    {
        rbCat = GetComponent<Rigidbody2D>();//captura o rigidBody2d do gato
    }

    
    void Update()
    {
        if (imgEnergia.fillAmount <=0)
        {

        } 

        if (imgEnergia.fillAmount >=0.01f && Input.GetKey(KeyCode.Mouse0))//condicional que verifica se o botão esquerdo do mouse é pressionado e se a barra de enegia n está vazia
        {
            //ações que acontecem se o botão do mouse for clicado
            rbCat.AddForce( new Vector2(0, jumpForce * Time.deltaTime));//adiciona uma velocidade no eixo y
            imgEnergia.fillAmount -= 0.22f*Time.deltaTime;//diminue o tamanho da barra de energia
        }
        else
        {
            imgEnergia.fillAmount += 0.05f*Time.deltaTime;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//verifica se o gato esta colidindo com outros objetos
    {
        switch (collision.gameObject.tag)//verifica qual o tipo de objeto o gato esta colidindo de acordo com sua tag
        {
            case "Plataforma"://se a tag for "Plataforma"
                imgEnergia.fillAmount -= 0.10f;//diminui a barra de energia
                break;
            case "Peixe":
                imgEnergia.fillAmount += 0.10f;
                break;
            default:
                break;
        }
        
    }
}
