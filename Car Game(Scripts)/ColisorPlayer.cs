using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorPlayer : MonoBehaviour
{
    public Rigidbody playerRB;
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
            case "inimigo":
                Destroy(gameObject);
                
                break;

            case "faixaMeio":
                playerRB.velocity = Vector3.zero;

                break;

            default:
                break;
        }
    }
}
