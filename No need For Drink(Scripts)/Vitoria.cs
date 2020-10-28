using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitoria : MonoBehaviour
{
    public UnityEngine.UI.Text MpontosTXT;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MpontosTXT.text = "pontos : " + PlayerControl.moedas.ToString();
    }
}
