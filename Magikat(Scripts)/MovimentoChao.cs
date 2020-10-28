using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoChao : MonoBehaviour
{
    public Renderer rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(3f * Time.deltaTime, 0);//modifica o componente offset do material no eixo 
    }
}
