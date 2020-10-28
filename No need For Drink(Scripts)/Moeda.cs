using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moeda : PlayerControl
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                Destroy(gameObject);
                pontos += 1;
                SoundManager.PlaySom("coin");
                break;
            case "CArro":
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
}
