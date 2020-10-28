using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selecaonivel : MonoBehaviour
{
    public Rigidbody2D bkRB;

    void Start()
    {
        
    }
    public void nivel_BTN(string cena)
    {
        SceneManager.LoadScene(cena);

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -7)
        {
            bkRB.velocity = new Vector2(2, 0);
        }
       

        if (transform.position.x >= -1.61)
        {
            bkRB.velocity = new Vector2(-2, 0);
        }
       
    }



}
