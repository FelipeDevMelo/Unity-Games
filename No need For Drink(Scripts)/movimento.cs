using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    public static float movimentoSpeed = -4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, movimentoSpeed*Time.deltaTime, 0);
        if (transform.position.y<-5)
        {
            Destroy(gameObject);
        }
    }
  

}
