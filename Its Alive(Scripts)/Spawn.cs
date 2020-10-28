using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    public Button[] control;
    public Transform img;
    public GameObject[] head;
    public GameObject[] body;
    public GameObject[] leg;
    public GameObject[] armL;
    public GameObject[] armR;
    public Transform[] posshape;

  public void vldBTN()
    {
        head[0].transform.position = img.position;
        head[1].transform.position = img.position;
        head[2].transform.position = img.position;
        body[0].transform.position = img.position;
        body[1].transform.position = img.position;
        body[2].transform.position = img.position;
        leg[0].transform.position = img.position;
        leg[1].transform.position = img.position;
        leg[2].transform.position = img.position;
        armL[0].transform.position = img.position;
        armL[1].transform.position = img.position;
        armL[2].transform.position = img.position;
        armR[0].transform.position = img.position;
        armR[1].transform.position = img.position;
        armR[2].transform.position = img.position;

        head[0].transform.position = posshape[2].transform.position;
        body[1].transform.position = posshape[1].transform.position;
        leg[0].transform.position = posshape[0].transform.position;
        armL[0].transform.position = posshape[3].transform.position;
        armR[0].transform.position = posshape[4].transform.position;
    }
    
   

    public void Body()
    {
      
    }

    public void Leg()
    {
       
    }

    public void Larm()
    {
       
    }

    public void Rarm()
    {
        
    }
    public void thoriBTN()
    {
        head[0].transform.position = img.position;
        head[1].transform.position = img.position;
        head[2].transform.position = img.position;
        body[0].transform.position = img.position;
        body[1].transform.position = img.position;
        body[2].transform.position = img.position;
        leg[0].transform.position = img.position;
        leg[1].transform.position = img.position;
        leg[2].transform.position = img.position;
        armL[0].transform.position = img.position;
        armL[1].transform.position = img.position;
        armL[2].transform.position = img.position;
        armR[0].transform.position = img.position;
        armR[1].transform.position = img.position;
        armR[2].transform.position = img.position;

        head[2].transform.position = posshape[2].transform.position;
        body[0].transform.position = posshape[1].transform.position;
        leg[2].transform.position = posshape[0].transform.position;
        armL[2].transform.position = posshape[3].transform.position;
        armR[2].transform.position = posshape[4].transform.position;
    }
    public void frankBTN()
    {
        head[0].transform.position = img.position;
        head[1].transform.position = img.position;
        head[2].transform.position = img.position;
        body[0].transform.position = img.position;
        body[1].transform.position = img.position;
        body[2].transform.position = img.position;
        leg[0].transform.position = img.position;
        leg[1].transform.position = img.position;
        leg[2].transform.position = img.position;
        armL[0].transform.position = img.position;
        armL[1].transform.position = img.position;
        armL[2].transform.position = img.position;
        armR[0].transform.position = img.position;
        armR[1].transform.position = img.position;
        armR[2].transform.position = img.position;

        head[1].transform.position = posshape[2].transform.position;
        body[2].transform.position = posshape[1].transform.position;
        leg[1].transform.position = posshape[0].transform.position;
        armL[1].transform.position = posshape[3].transform.position;
        armR[1].transform.position = posshape[4].transform.position;

    }

    private void Start()
    {

      
    }
    public Player_combat player_Combat;
    public void resetapecas()
    {
       
        
        Status_view.preenchimento = 0;
        control[2].interactable = true;
        control[6].interactable = true;
        control[11].interactable = true;
        control[0].interactable = true;
        control[5].interactable = true;
        control[10].interactable = true;
        control[3].interactable = true;
        control[8].interactable = true;
        control[13].interactable = true;
        control[4].interactable = true;
        control[9].interactable = true;
        control[14].interactable = true;
        control[1].interactable = true;
        control[7].interactable = true;
        control[12].interactable = true;
        head[0].transform.position = img.position;
        head[1].transform.position = img.position;
        head[2].transform.position = img.position;
        body[0].transform.position = img.position;
        body[1].transform.position = img.position;
        body[2].transform.position = img.position;
        leg[0].transform.position = img.position;
        leg[1].transform.position = img.position;
        leg[2].transform.position = img.position;
        armL[0].transform.position = img.position;
        armL[1].transform.position = img.position;
        armL[2].transform.position = img.position;
        armR[0].transform.position = img.position;
        armR[1].transform.position = img.position;
        armR[2].transform.position = img.position;
        switch (GameManager.nomeLarm)
        {
            case "braço_FRankL":

                GameManager.energiaAtual += 18;

                break;
            case "braço_tauroL":

                GameManager.energiaAtual += 11;

                break;
            case "braçoE_gato":
                GameManager.energiaAtual += 4;
                break;
            default:
                break;
        }
        switch (GameManager.nomeRarm)
        {
            case "braço_frankR":

                GameManager.energiaAtual += 18;
                break;
            case "braço_tauroR":
                GameManager.energiaAtual += 9;
                break;
            case "braçoD_gato":
                GameManager.energiaAtual += 4;
                break;
            case null:

                break;
            default:

                break;
        }
        switch (GameManager.nomeBody)
        {
            case "torso_FRank":

                GameManager.energiaAtual += 38;

                break;
            case "torso_tauro":


                GameManager.energiaAtual += 20;

                break;
            case "troso_gato":

                GameManager.energiaAtual += 15;



                break;
            default:
                break;
        }
        switch (GameManager.nomeLegs)
        {
            case "pernas_FRank":
                GameManager.energiaAtual += 26;


                break;
            case "pernas_tauro":
                GameManager.energiaAtual += 21;
                break;
            case "Pernas_gato":
                GameManager.energiaAtual += 8;
                break;
            default:
                break;
        }
        switch (GameManager.nomeHead)
        {
            case "cabeça_FRank":

                GameManager.energiaAtual += 14;
                break;
            case "cabeça_tauro":
                GameManager.energiaAtual += 14;


                break;
            case "cabeça_gato":

                GameManager.energiaAtual += 10;


                break;


            default:
                break;
        }
        player_Combat.resetatd();
    }
   
  
   
    private void Update()
    {
        if (GameManager.energiaAtual <GameManager.energiaMax)
        {
            if (GameManager.nomeHead != null)
            {
                control[0].interactable = false;
                control[5].interactable = false;
                control[10].interactable = false;
            }
            else
            {
                control[0].interactable = true;
                control[5].interactable = true;
                control[10].interactable = true;
            }
            if (GameManager.nomeBody != null)
            {
                control[3].interactable = false;
                control[8].interactable = false;
                control[13].interactable = false;
            }
            else
            {
                control[3].interactable = true;
                control[8].interactable = true;
                control[13].interactable = true;
            }
            if (GameManager.nomeLegs != null)
            {
                control[4].interactable = false;
                control[9].interactable = false;
                control[14].interactable = false;
            }
            else
            {
                control[4].interactable = true;
                control[9].interactable = true;
                control[14].interactable = true;
            }
            if (GameManager.nomeLarm != null)
            {
                control[1].interactable = false;
                control[7].interactable = false;
                control[12].interactable = false;
            }
            else
            {
                control[1].interactable = true;
                control[7].interactable = true;
                control[12].interactable = true;
            }
            if (GameManager.nomeRarm != null)
            {
                control[2].interactable = false;
                control[6].interactable = false;
                control[11].interactable = false;
            }
            else
            {
                control[2].interactable = true;
                control[6].interactable = true;
                control[11].interactable = true;
            }
           
        }
        
    }

}

