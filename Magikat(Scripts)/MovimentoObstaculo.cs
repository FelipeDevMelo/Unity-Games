using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoObstaculo : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate (new Vector2(-8 * Time.deltaTime, 0));//modifica a posição do obstaculo no eixo x
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
