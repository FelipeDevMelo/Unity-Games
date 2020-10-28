using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lixo : MonoBehaviour
{
    private float currentTime;
    public float timeRange;
    void Start()
    {
        
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime>=timeRange)
        {
            UI.barraLife.fillAmount += 0.10f;
            currentTime = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
