using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : PlayerControl
{
    public GameObject D4;
    public GameObject carro2;
    public GameObject carro3;
    public GameObject carro4;
    public GameObject carro5;
    public GameObject carro6;
    public GameObject D3;
    public GameObject D2;
    public GameObject D1;
    public GameObject chegada;
    public GameObject moeda;
   public GameObject carro;
    private float currentTime;
    public float Range;
    private Transform spawnT;
    private float x;
    private float currentTimeM;
    public float rangeM;
    private float currentTimeD1;
    public float rangeD1;
    private float currentTimeD2;
    public float rangeD2;
    private float currentTimeD3;
    public float rangeD3;
    private float currentTimeD4;
    public float rangeD4;
    private float currentTimeC2;
    public float rangeC2;
    private float currentTimeC3;
    public float rangeC3;
    private float currentTimeC4;
    public float rangeC4;
    private float currentTimeC5;
    public float rangeC5;
    private float currentTimeC6;
    public float rangeC6;
    private float currentTimeChegada;
    public float rangeChegada;
    public float currentTimeGeral;
    private float rangeTimeGeral = 30;
    void Start()
    {
        spawnT = GetComponent<Transform>();
        currentTime = 0;
        currentTimeGeral = 0;
    }

    
    void Update()
    {

        currentTimeGeral += Time.deltaTime;
        if (currentTimeGeral>=rangeTimeGeral)
        {
            movimento.movimentoSpeed -= 1.5f;
            Pista.yVelocidade += 0.1f;
            currentTimeGeral = 0;
        }




        currentTimeC6 += Time.deltaTime;
        if (currentTimeC6 >= rangeC6)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeC6 = 0;
            GameObject TempPrefab8 = Instantiate(carro6) as GameObject;
            TempPrefab8.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTimeC5 += Time.deltaTime;
        if (currentTimeC5 >= rangeC5)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeC5 = 0;
            GameObject TempPrefab8 = Instantiate(carro5) as GameObject;
            TempPrefab8.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

        currentTimeC4 += Time.deltaTime;
        if (currentTimeC4 >= rangeC4)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeC4 = 0;
            GameObject TempPrefab7 = Instantiate(carro4) as GameObject;
            TempPrefab7.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

        currentTimeC3 += Time.deltaTime;
        if (currentTimeC3 >= rangeC3)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeC3 = 0;
            GameObject TempPrefab6 = Instantiate(carro3) as GameObject;
            TempPrefab6.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTimeD3 += Time.deltaTime;
        if (currentTimeD3 >= rangeD3)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeD3 = 0;
            GameObject TempPrefab5 = Instantiate(D3) as GameObject;
            TempPrefab5.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTimeD4 += Time.deltaTime;
        if (currentTimeD4 >= rangeD4)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeD4 = 0;
            GameObject TempPrefab0 = Instantiate(D4) as GameObject;
            TempPrefab0.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTimeD2 += Time.deltaTime;
        if (currentTimeD2 >= rangeD2)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeD2 = 0;
            GameObject TempPrefab4 = Instantiate(D2) as GameObject;
            TempPrefab4.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

        currentTimeD1 += Time.deltaTime;
        if (currentTimeD1 >= rangeD1)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeD1 = 0;
            GameObject TempPrefab = Instantiate(D1) as GameObject;
            TempPrefab.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTimeChegada += Time.deltaTime;
        if (currentTimeChegada>=rangeChegada)
        {
            GameObject tempPrefab3 = Instantiate(chegada) as GameObject;
            tempPrefab3.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            currentTimeChegada = 0;
        }
        currentTimeC2 += Time.deltaTime;
        if (currentTimeC2 >= rangeC2)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeC2 = 0;
            GameObject TempPrefab6 = Instantiate(carro2) as GameObject;
            TempPrefab6.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }
        currentTime += Time.deltaTime;
        if (currentTime >= Range)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTime = 0;
            GameObject TempPrefab = Instantiate(carro) as GameObject;
            TempPrefab.transform.position = new Vector3(x, transform.position.y, transform.position.z);
          
        }
        currentTimeM += Time.deltaTime;
        if (currentTimeM >= rangeM)
        {
            x = Random.Range(-2.07f, 2.03f);
            currentTimeM = 0;
           
            GameObject TempPrefab2 = Instantiate(moeda) as GameObject;
            TempPrefab2.transform.position = new Vector3(x, transform.position.y, transform.position.z);

        }

    }
}
