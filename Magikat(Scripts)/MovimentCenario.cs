using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentCenario : MonoBehaviour
{
    public Renderer rend;
    void Start()
    {
       
    }

    
    void Update()
    {
        rend.material.mainTextureOffset += new Vector2(0.3f * Time.deltaTime, 0);//modifica o componente offset do material no eixo x
    }
}
