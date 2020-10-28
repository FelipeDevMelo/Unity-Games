using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorInimigo : MonoBehaviour
{
    public GameObject carroceria;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "player":
                Destroy(gameObject);
                Destroy(carroceria);
                break;
            case "destruidor":
                Destroy(gameObject);
                Destroy(carroceria);
                break;

            default:
                break;
        }
    }
}
