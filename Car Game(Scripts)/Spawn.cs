using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject inimigo;
    private float currentTime;
    private float timeRange;
    public float x , i , f;
    void Start()
    {
        
    }

    
    void Update()
    {
        timeRange = Random.Range(i, f);
        currentTime += Time.deltaTime;
        if (currentTime >= timeRange)
        {
            currentTime = 0;
            
            GameObject TempPrefab = Instantiate(inimigo) as GameObject;
            TempPrefab.transform.position = new Vector3(x, 1529f, transform.position.z);

        }
        
    }
}
