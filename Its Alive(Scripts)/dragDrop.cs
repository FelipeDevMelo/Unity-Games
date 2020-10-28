using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class dragDrop : MonoBehaviour
{
   






    
    /* switch (this.gameObject.tag)
     {
         case "cabeça":
             GameManager.nomeHead = this.gameObject.name;
             GameManager.nomeHead_status = this.gameObject.name;
             break;
         case "torso":
             GameManager.nomeBody = this.gameObject.name;
             GameManager.nomeBody_status = this.gameObject.name;
             break;
         case "Larm":
             GameManager.nomeLarm = this.gameObject.name;
             GameManager.nomeLarm_status = this.gameObject.name;
             break;
         case "Rarm":
             GameManager.nomeRarm = this.gameObject.name;
             GameManager.nomeRarm_status = this.gameObject.name;
             break;
         case "legs":
             GameManager.nomeLegs = this.gameObject.name;
             GameManager.nomeLegs_status = this.gameObject.name;
             break;
         default:
             break;
     }*/





    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        switch (GameManager.nomeLarm_status)
        {
            case "braço_FRankL":
                Status_Player.force += 18;
                Status_Player.vida += 15;
                
                Combo_Efeitos.n_pecas_frank += 1;

                GameManager.nomeLarm_status = null;
                break;
            case "braço_tauroL":
                Status_Player.force += 4;
                Status_Player.armor += 1;

                Status_Player.atkspd += 0.4f;
                Combo_Efeitos.n_pecas_tauro += 1;

                GameManager.nomeLarm_status = null;
                break;
            case "braçoE_gato":
                Status_Player.force += 10;


                Combo_Efeitos.n_pecas_gato += 1;
                GameManager.nomeLarm_status = null;

                break;
            default:
                break;
        }
        switch (GameManager.nomeRarm_status)
        {
            case "braço_frankR":
                Status_Player.force += 18;
                Status_Player.vida += 15;
                Combo_Efeitos.n_pecas_frank += 1;
                GameManager.nomeRarm_status = null;

                break;
            case "braço_tauroR":
                Status_Player.force += 9;
                Status_Player.armor += 2;
                Status_Player.atkspd += 0.2f;
                Combo_Efeitos.n_pecas_tauro += 1;
                GameManager.nomeRarm_status = null;

                break;
            case "braçoD_gato":
                Status_Player.force += 10;


                Combo_Efeitos.n_pecas_gato += 1;
                GameManager.nomeRarm_status = null;

                break;
            default:
                break;
        }
        switch (GameManager.nomeBody_status)
        {
            case "torso_FRank":
                Status_Player.force += 7;
                Status_Player.vida += 45;
                Combo_Efeitos.n_pecas_frank += 1;
                GameManager.nomeBody_status = null;

                break;
            case "torso_tauro":

                Status_Player.armor += 4;
                Status_Player.vida += 20;
                Combo_Efeitos.n_pecas_tauro += 1;
                GameManager.nomeBody_status = null;

                break;
            case "troso_gato":
                Status_Player.force += 2;
                Status_Player.vida += 18;
                Combo_Efeitos.n_pecas_gato += 1;
                GameManager.nomeBody_status = null;

                break;
            default:
                break;
        }
        switch (GameManager.nomeLegs_status)
        {
            case "pernas_FRank":
                Status_Player.force += 7;
                Status_Player.vida += 30;
                Combo_Efeitos.n_pecas_frank += 1;
                GameManager.nomeLegs_status = null;
                    
                break;
            case "pernas_tauro":
                Status_Player.force += 5f;
                Status_Player.atkspd += 0.2f;
                Status_Player.vida += 20;
                Combo_Efeitos.n_pecas_tauro += 1;
                GameManager.nomeLegs_status = null;

                break;
            case "Pernas_gato":

                Status_Player.vida += 10;
                Combo_Efeitos.n_pecas_gato += 1;
                GameManager.nomeLegs_status = null;

                break;
            default:
                break;
        }
        switch (GameManager.nomeHead_status)
        {
            case "cabeça_FRank":
                Status_Player.force += 5;
                Status_Player.vida += 15;
                Combo_Efeitos.n_pecas_frank += 1;
                GameManager.nomeHead_status = null;

                break;
            case "cabeça_tauro":
                Status_Player.atkspd += 0.2f;
                Status_Player.armor += 3;
                Status_Player.vida += 10;
                Combo_Efeitos.n_pecas_tauro += 1;
                GameManager.nomeHead_status = null;

                break;
            case "cabeça_gato":
                Status_Player.force += 3;
                Status_Player.vida += 12;
                Combo_Efeitos.n_pecas_gato += 1;
                GameManager.nomeHead_status = null;

                break;


            default:
                break;
        }

    }

}
