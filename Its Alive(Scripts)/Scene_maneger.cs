using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_maneger : MonoBehaviour
{
    public Animator trans_BTN;
    public GameObject pai;
    
    public GameObject player;
    public Player_combat player_Combat;
    
    /// <summary>
    
    /// </summary>
    
   
   
   
    /// <summary>
    
    /// </summary>
    
    /// <summary>
 
    /// </summary>
    public GameObject selecao;
    public GameObject batoufild;
   
    private void Start()
    {
        bodyCountPlayer = 0;
        pai.transform.GetChild(1).gameObject.SetActive(false);
        pai.transform.GetChild(2).gameObject.SetActive(false);
        pai.transform.GetChild(3).gameObject.SetActive(false);
        pai.transform.GetChild(4).gameObject.SetActive(false);
        pai.transform.GetChild(5).gameObject.SetActive(false);
        pai.transform.GetChild(6).gameObject.SetActive(false);
        pai.transform.GetChild(7).gameObject.SetActive(false);
        pai.transform.GetChild(8).gameObject.SetActive(false);
        pai.transform.GetChild(9).gameObject.SetActive(false);
        pai.transform.GetChild(10).gameObject.SetActive(false);
        pai.transform.GetChild(11).gameObject.SetActive(false);
        pai.transform.GetChild(12).gameObject.SetActive(false);
        pai.transform.GetChild(13).gameObject.SetActive(false);
        pai.transform.GetChild(14).gameObject.SetActive(false);
        pai.transform.GetChild(15).gameObject.SetActive(false);
        pai.transform.GetChild(16).gameObject.SetActive(false);
        pai.transform.GetChild(17).gameObject.SetActive(false);
        pai.transform.GetChild(18).gameObject.SetActive(false);
        pai.transform.GetChild(19).gameObject.SetActive(false);
        pai.transform.GetChild(20).gameObject.SetActive(false);
        pai.transform.GetChild(21).gameObject.SetActive(false);
        pai.transform.GetChild(22).gameObject.SetActive(false);
        pai.transform.GetChild(23).gameObject.SetActive(false);
        pai.transform.GetChild(24).gameObject.SetActive(false);
        pai.transform.GetChild(25).gameObject.SetActive(false);
        pai.transform.GetChild(26).gameObject.SetActive(false);
        pai.transform.GetChild(27).gameObject.SetActive(false);
        pai.transform.GetChild(28).gameObject.SetActive(false);
        pai.transform.GetChild(29).gameObject.SetActive(false);
        pai.transform.GetChild(30).gameObject.SetActive(false);
        pai.transform.GetChild(31).gameObject.SetActive(false);
        pai.transform.GetChild(32).gameObject.SetActive(false);
        pai.transform.GetChild(33).gameObject.SetActive(false);
        pai.transform.GetChild(34).gameObject.SetActive(false);
        pai.transform.GetChild(35).gameObject.SetActive(false);
        pai.transform.GetChild(36).gameObject.SetActive(false);
        pai.transform.GetChild(37).gameObject.SetActive(false);
        pai.transform.GetChild(38).gameObject.SetActive(false);
        pai.transform.GetChild(39).gameObject.SetActive(false);
        pai.transform.GetChild(40).gameObject.SetActive(false);
        pai.transform.GetChild(41).gameObject.SetActive(false);
        pai.transform.GetChild(42).gameObject.SetActive(false);
        pai.transform.GetChild(43).gameObject.SetActive(false);
        pai.transform.GetChild(44).gameObject.SetActive(false);
        pai.transform.GetChild(45).gameObject.SetActive(false);
        pai.transform.GetChild(46).gameObject.SetActive(false);
        pai.transform.GetChild(47).gameObject.SetActive(false);
    }
   


    private void Update()
    {

    }



    public void changeScene(string cena)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(cena);
        GameManager.bodycount = 0;
    }
    public GameObject hud;
    
    public void selecao_BTN(bool verifi )
    {
        selecao.SetActive(verifi);

        if (selecao)
        {
            hud.SetActive(false);
        }
        
        
        
    }

   
    public void rolar2()
    {
       
       
            hud.SetActive(true);
        
        
    }
    
    public void changescene_aliveBTN()
    {

        switch (GameManager.nomeLarm)
        {
            case "braço_FRankL":
                pai.transform.GetChild(5).gameObject.SetActive(true);
                pai.transform.GetChild(6).gameObject.SetActive(true);
                pai.transform.GetChild(7).gameObject.SetActive(true);
                ////////////////////////////////////////////////////////
                pai.transform.GetChild(18).gameObject.SetActive(false);
                pai.transform.GetChild(19).gameObject.SetActive(false);
                pai.transform.GetChild(20).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(34).gameObject.SetActive(false);
                pai.transform.GetChild(35).gameObject.SetActive(false);
                pai.transform.GetChild(36).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////


                break;
            case "braço_tauroL":

                pai.transform.GetChild(18).gameObject.SetActive(true);
                pai.transform.GetChild(19).gameObject.SetActive(true);
                pai.transform.GetChild(20).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(5).gameObject.SetActive(false);
                pai.transform.GetChild(6).gameObject.SetActive(false);
                pai.transform.GetChild(7).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(34).gameObject.SetActive(false);
                pai.transform.GetChild(35).gameObject.SetActive(false);
                pai.transform.GetChild(36).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////

                break;
            case "braçoE_gato":
                pai.transform.GetChild(34).gameObject.SetActive(true);
                pai.transform.GetChild(35).gameObject.SetActive(true);
                pai.transform.GetChild(36).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(5).gameObject.SetActive(false);
                pai.transform.GetChild(6).gameObject.SetActive(false);
                pai.transform.GetChild(7).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(18).gameObject.SetActive(false);
                pai.transform.GetChild(19).gameObject.SetActive(false);
                pai.transform.GetChild(20).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                break;
            default:
                break;
        }
        switch (GameManager.nomeRarm)
        {
            case "braço_frankR":

                pai.transform.GetChild(9).gameObject.SetActive(true);
                pai.transform.GetChild(10).gameObject.SetActive(true);
                pai.transform.GetChild(11).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(24).gameObject.SetActive(false);
                pai.transform.GetChild(25).gameObject.SetActive(false);
                pai.transform.GetChild(26).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(40).gameObject.SetActive(false);
                pai.transform.GetChild(41).gameObject.SetActive(false);
                pai.transform.GetChild(42).gameObject.SetActive(false);
                break;
            case "braço_tauroR":
                pai.transform.GetChild(24).gameObject.SetActive(true);
                pai.transform.GetChild(25).gameObject.SetActive(true);
                pai.transform.GetChild(26).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(9).gameObject.SetActive(false);
                pai.transform.GetChild(10).gameObject.SetActive(false);
                pai.transform.GetChild(11).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(40).gameObject.SetActive(false);
                pai.transform.GetChild(41).gameObject.SetActive(false);
                pai.transform.GetChild(42).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                break;
            case "braçoD_gato":
                pai.transform.GetChild(40).gameObject.SetActive(true);
                pai.transform.GetChild(41).gameObject.SetActive(true);
                pai.transform.GetChild(42).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(9).gameObject.SetActive(false);
                pai.transform.GetChild(10).gameObject.SetActive(false);
                pai.transform.GetChild(11).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(24).gameObject.SetActive(false);
                pai.transform.GetChild(25).gameObject.SetActive(false);
                pai.transform.GetChild(26).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                break;
            case null:

                break;
            default:

                break;
        }
        switch (GameManager.nomeBody)
        {
            case "torso_FRank":
                pai.transform.GetChild(15).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(30).gameObject.SetActive(false);
                pai.transform.GetChild(31).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(46).gameObject.SetActive(false);
                pai.transform.GetChild(47).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////


                break;
            case "torso_tauro":
                pai.transform.GetChild(15).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(30).gameObject.SetActive(true);
                pai.transform.GetChild(31).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(46).gameObject.SetActive(false);
                pai.transform.GetChild(47).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////



                break;
            case "troso_gato":
                pai.transform.GetChild(46).gameObject.SetActive(true);
                pai.transform.GetChild(47).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(15).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(30).gameObject.SetActive(false);
                pai.transform.GetChild(31).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////




                break;
            default:
                break;
        }
        switch (GameManager.nomeLegs)
        {
            case "pernas_FRank":
                pai.transform.GetChild(1).gameObject.SetActive(true);
                pai.transform.GetChild(2).gameObject.SetActive(true);
                pai.transform.GetChild(8).gameObject.SetActive(true);
                pai.transform.GetChild(12).gameObject.SetActive(true);
                pai.transform.GetChild(13).gameObject.SetActive(true);
                pai.transform.GetChild(14).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(21).gameObject.SetActive(false);
                pai.transform.GetChild(22).gameObject.SetActive(false);
                pai.transform.GetChild(23).gameObject.SetActive(false);
                pai.transform.GetChild(27).gameObject.SetActive(false);
                pai.transform.GetChild(28).gameObject.SetActive(false);
                pai.transform.GetChild(29).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(43).gameObject.SetActive(false);
                pai.transform.GetChild(44).gameObject.SetActive(false);
                pai.transform.GetChild(45).gameObject.SetActive(false);
                pai.transform.GetChild(37).gameObject.SetActive(false);
                pai.transform.GetChild(38).gameObject.SetActive(false);
                pai.transform.GetChild(39).gameObject.SetActive(false);


                break;
            case "pernas_tauro":
                pai.transform.GetChild(21).gameObject.SetActive(true);
                pai.transform.GetChild(22).gameObject.SetActive(true);
                pai.transform.GetChild(23).gameObject.SetActive(true);
                pai.transform.GetChild(27).gameObject.SetActive(true);
                pai.transform.GetChild(28).gameObject.SetActive(true);
                pai.transform.GetChild(29).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(1).gameObject.SetActive(false);
                pai.transform.GetChild(2).gameObject.SetActive(false);
                pai.transform.GetChild(8).gameObject.SetActive(false);
                pai.transform.GetChild(12).gameObject.SetActive(false);
                pai.transform.GetChild(13).gameObject.SetActive(false);
                pai.transform.GetChild(14).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(43).gameObject.SetActive(false);
                pai.transform.GetChild(44).gameObject.SetActive(false);
                pai.transform.GetChild(45).gameObject.SetActive(false);
                pai.transform.GetChild(37).gameObject.SetActive(false);
                pai.transform.GetChild(38).gameObject.SetActive(false);
                pai.transform.GetChild(39).gameObject.SetActive(false);
                break;
            case "Pernas_gato":
                pai.transform.GetChild(43).gameObject.SetActive(true);
                pai.transform.GetChild(44).gameObject.SetActive(true);
                pai.transform.GetChild(45).gameObject.SetActive(true);
                pai.transform.GetChild(37).gameObject.SetActive(true);
                pai.transform.GetChild(38).gameObject.SetActive(true);
                pai.transform.GetChild(39).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(1).gameObject.SetActive(false);
                pai.transform.GetChild(2).gameObject.SetActive(false);
                pai.transform.GetChild(8).gameObject.SetActive(false);
                pai.transform.GetChild(12).gameObject.SetActive(false);
                pai.transform.GetChild(13).gameObject.SetActive(false);
                pai.transform.GetChild(14).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(21).gameObject.SetActive(false);
                pai.transform.GetChild(22).gameObject.SetActive(false);
                pai.transform.GetChild(23).gameObject.SetActive(false);
                pai.transform.GetChild(27).gameObject.SetActive(false);
                pai.transform.GetChild(28).gameObject.SetActive(false);
                pai.transform.GetChild(29).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                break;
            default:
                break;
        }
        switch (GameManager.nomeHead)
        {
            case "cabeça_FRank":
                pai.transform.GetChild(3).gameObject.SetActive(true);
                pai.transform.GetChild(4).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(16).gameObject.SetActive(false);
                pai.transform.GetChild(17).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(32).gameObject.SetActive(false);
                pai.transform.GetChild(33).gameObject.SetActive(false);

                //////////////////////////////
                break;
            case "cabeça_tauro":
                pai.transform.GetChild(16).gameObject.SetActive(true);
                pai.transform.GetChild(17).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(3).gameObject.SetActive(false);
                pai.transform.GetChild(4).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(32).gameObject.SetActive(false);
                pai.transform.GetChild(33).gameObject.SetActive(false);
                /////////////////////////////////


                break;
            case "cabeça_gato":
                pai.transform.GetChild(32).gameObject.SetActive(true);
                pai.transform.GetChild(33).gameObject.SetActive(true);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(3).gameObject.SetActive(false);
                pai.transform.GetChild(4).gameObject.SetActive(false);
                //////////////////////////////////////////////////////////
                pai.transform.GetChild(16).gameObject.SetActive(false);
                pai.transform.GetChild(17).gameObject.SetActive(false);



                break;


            default:
                break;
        }



        player_Combat.atkspeed = Status_Player.atkspd;
        player_Combat.force = Status_Player.force;
        player_Combat.health_bar.maxValue = Status_Player.vida;
        player_Combat.health_bar.value = Status_Player.vida;
        player_Combat.armadura = Status_Player.armor;
        player_Combat.n_pecas[0] = Combo_Efeitos.n_pecas_frank;
        player_Combat.n_pecas[1] = Combo_Efeitos.n_pecas_gato;
        player_Combat.n_pecas[2] = Combo_Efeitos.n_pecas_tauro;
        Camera.terminouOtuto = true;
        GameObject TempPrefab = Instantiate(player) as GameObject;
        TempPrefab.transform.position = new Vector3(-300, -89, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
        GameManager.bodycount += 1;
        bodyCountPlayer += 1;
        Status_view.preenchimento = 0;
        trans_BTN.SetTrigger("Normal");
        
        player_Combat.resetatd();

      



    }
    public static int bodyCountPlayer;
}
        
        
    
    
   


