using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject peixe;//armazena o coletavel "peixe" q sera spawnado
    public GameObject obstaculo1;//armazena o obstaculo q sera spawnado
    private float currentTime;//conta o tempo decorrido no jogo
    public float timeRange;//tempo de intervalo de spawn para os obstaculos
    private float currentTimePeixe;
    public float timeRangePeixe;
    void Start()
    {
        currentTime = 0;//inicia o jogo com o tempo decorrido recebendo o valor de 0
    }

   
    void Update()
    {
        currentTimePeixe += Time.deltaTime;
        if (currentTimePeixe >= timeRangePeixe)
        {
            float yp = Random.Range(-2.9f, 3.7f);//cria um numero aleatorio emtre -2.9 e 3.7
            currentTimePeixe = 0; //o tempo recorrido é reiniciado para poder recomeçar a contagem e spawnar outro peixe
            GameObject temPrefabPeixe = Instantiate(peixe) as GameObject;//faz surgir um peixe
            temPrefabPeixe.transform.position = new Vector2(transform.position.x, yp);//cria coordenadas para onde o obstaculo ira nascer
            
        }

        currentTime += Time.deltaTime;//aumenta de acordo com o tempo decorrido 
        if (currentTime >=timeRange)//verifica se o tempo decorrido chegou ao limite pre estabelecido
        {
            float y = Random.Range(-7f, -3f);//cria um numero aleatorio emtre -7 e 3
            currentTime = 0; //o tempo recorrido é reiniciado para poder recomeçar a contagem e spawnar outro obstaculo
            GameObject temPrefab = Instantiate(obstaculo1) as GameObject;//faz surgir um obstaculo
            temPrefab.transform.position = new Vector2(transform.position.x, y);//cria coordenadas para onde o obstaculo ira nascer
        }
    }
}
