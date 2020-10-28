using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static bool multiplayer=false;
    public GameObject aliveBTN,desfazerBTN,jogadortxtGameobject;
    public static bool podeLutar;
    public Slider energiabar;
    public int contador;
    public static int bodycount;
    public static string turno;
    public static int energiaAtual,energiaMax;
    public Text turnotxt, jogadortxt,vidatxt,energiaTXT, armortxt, forcatxt, misticotxt , num_pecasfranktxt , numpecasgatotxt ,numpecasTaurotxt;
    public static string nomeHead_status;
    public static string nomeBody_status;
    public static string nomeLegs_status;
    public static string nomeLarm_status;
    public static string nomeRarm_status;
    public static string nomeHead;
    public static string nomeBody;
    public static string nomeLegs;
    public static string nomeLarm;
    public static string nomeRarm;
    public static AudioClip vuf;
   public static AudioSource audioscr;
    public static bool bateuNexusP, bateuNexusenemy;

    public GameObject pausa1, pausa2 , menu , restart;
    IEnumerator waitsecs1()
    {
        pausa1.SetActive(false);
        pausa2.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        Time.timeScale = 0;
    }
    IEnumerator waitsecs2()
    {
        pausa1.SetActive(true);
        pausa2.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        Time.timeScale = 1;
    }
    public static int rodada = 1;
    public static GameObject combateBtn;
    public void iniciaturno()
    {
       
        turno = "fase de combate";
        podeLutar = false;
        Camera.terminouTuto2 = true;
        
    }

    public void pausar()
    {

        StartCoroutine(waitsecs1());
        pausa1.SetActive(true);
        menu.SetActive(true);
        restart.SetActive(true);
        
    }
    public void pausar2()
    {
        Time.timeScale = 1;
        StartCoroutine(waitsecs2());
        
        menu.SetActive(false);
        restart.SetActive(false);

    }
    private void Awake()
    {
        podeLutar = false;
        combateBtn = GameObject.Find("combateBTN");
    }

    void Start()
    {
        if (multiplayer==true)
        {
            jogadortxtGameobject.SetActive(true);
        }
        audioscr = GetComponent<AudioSource>();
        novarodadaBTN = GameObject.Find("novarodadaBTN");
        
        rodada = 1;
        turno = "fase de criação";
        energiaAtual = 80;
        energiaMax = 80;
       
    }

    public static GameObject novarodadaBTN;
    void Update()
    {
        if (podeLutar == true)
        {
            combateBtn.SetActive(true);
        }
        else
        {
            combateBtn.SetActive(false);
        }

        if (Status_view.preenchimento >=5)
        {
            aliveBTN.SetActive(true);
            desfazerBTN.SetActive(true);
        }
        else
        {
            
            aliveBTN.SetActive(false);
        }

        if (Status_view.preenchimento>=1)
        {
            desfazerBTN.SetActive(true);
        }
        else
        {
            desfazerBTN.SetActive(false);
        }

        if (Spawn_cobaias.coounter == 1 && multiplayer == true)
        {
            jogadortxt.text = "Jogador 1";
        }
        else if (Spawn_cobaias.coounter == 2 && multiplayer == true)
        {
            jogadortxt.text = "Jogador 2";
        }
        energiabar.maxValue = energiaMax;
        energiabar.value = energiaAtual;
        contador = bodycount;
        
        if (bodycount<=0)
        {
            turno = "fase de criação";
            
            rodada += 1;
            bodycount = 1;
        }
        turnotxt.text = turno ;
        energiaTXT.text = energiaAtual + " / " + energiaMax;
        numpecasTaurotxt.text = "Peças tauro = " + Combo_Efeitos.n_pecas_tauro;
        num_pecasfranktxt.text = "Peças frank = " + Combo_Efeitos.n_pecas_frank;
        numpecasgatotxt.text = "Peças Vlad = " + Combo_Efeitos.n_pecas_gato;
        vidatxt.text = "vida = " + Status_Player.vida;
        forcatxt.text = "Força = " + Status_Player.force;
        armortxt.text = "Armadura = " + Status_Player.armor;
        misticotxt.text = "atk_spd = " + Status_Player.atkspd.ToString();
       
        

       
    }
}
