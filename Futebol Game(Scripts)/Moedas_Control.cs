using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas_Control : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
            Score_manager.instancia.ColetaMoedas(10);
            Audio_manager.instance.SonsFXToca(0);
            Destroy(this.gameObject);
        }
    }
}
