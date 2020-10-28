using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_manager : MonoBehaviour
{
    public static Score_manager instancia;
    public int moedas;

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void GameStartScoreM()
    {
        if (PlayerPrefs.HasKey("moedasSave"))
        {
            moedas = PlayerPrefs.GetInt("moedasSave");
        }
        else
        {
            moedas = 100;
            PlayerPrefs.SetInt("moedasSave", moedas);
        }
    }
    public void UpdateScore()
    {
        moedas = PlayerPrefs.GetInt("moedasSave");
    }
    public void SalvaMoedas(int coin)
    {
        PlayerPrefs.SetInt("moedasSave", coin);
    }
    public void ColetaMoedas(int coin)
    {
        moedas += coin;
        SalvaMoedas(moedas); 
    }
    public void PerdeMoedas(int coin)
    {
        moedas -= coin;
        SalvaMoedas(moedas);
    }
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
