using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Metal;
    public GameObject plastico;
    public GameObject papel;
    public GameObject vidro;
    public float metalRange;
    public float plasticoRange;
    public float papelRange;
    public float vidroRange;
    private float currentTimeMetal;
    private float currentTimePlastico;
    private float currentTimePapel;
    private float currentTimeVidro;
    private float xM;
    private float yM;
    private float xPapel;
    private float yPapel;
    private float xP;
    private float yP;
    private float xV;
    private float yV;
   

    void Start()
    {
        
    }

   
    void Update()
    {
        currentTimeMetal += Time.deltaTime;
        if (currentTimeMetal >= metalRange)
        {
            xM = Random.Range(-3.6f, 3.0f);
            yM = Random.Range(-3f, 3f);
            currentTimeMetal = 0;
            GameObject TempPrefab0 = Instantiate(Metal) as GameObject;
            TempPrefab0.transform.position = new Vector3(xM, yM, transform.position.z);
        }

        currentTimePlastico += Time.deltaTime;
        if (currentTimePlastico >= plasticoRange)
        {
            xP = Random.Range(-3.6f, 3.0f);
            yP = Random.Range(-3f, 3f);
            currentTimePlastico = 0;
            GameObject TempPrefab1 = Instantiate(plastico) as GameObject;
            TempPrefab1.transform.position = new Vector3(xP, yP, transform.position.z);
        }
        currentTimePapel += Time.deltaTime;
        if (currentTimePapel >= papelRange)
        {
            xPapel = Random.Range(-3.6f, 3.0f);
            yPapel = Random.Range(-3f, 3f);
            currentTimePapel = 0;
            GameObject TempPrefab2 = Instantiate(papel) as GameObject;
            TempPrefab2.transform.position = new Vector3(xPapel, yPapel, transform.position.z);
        }
        currentTimeVidro += Time.deltaTime;
        if (currentTimeVidro >= vidroRange)
        {
            xV = Random.Range(-3.6f, 3.0f);
            yV = Random.Range(-3f, 3f);
            currentTimeVidro = 0;
            GameObject TempPrefab3 = Instantiate(vidro) as GameObject;
            TempPrefab3.transform.position = new Vector3(xV, yV, transform.position.z);
        }



    }
}
