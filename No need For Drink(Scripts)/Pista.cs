using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pista : MonoBehaviour
{
    private Material material;
   static public float yVelocidade , xVelocidade;
    Vector2 offSet;

    private void Awake()
    {
        yVelocidade = 0.3f;

        xVelocidade = 0;
        material = GetComponent<Renderer>().material;
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        offSet = new Vector2(xVelocidade*Time.deltaTime, yVelocidade*Time.deltaTime);  
        material.mainTextureOffset += offSet;
    }
    void Update()
    {
        
    }
}
