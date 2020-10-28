using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public GameObject jogarB, tuto1,txtTuto1,proximo1, tuto2,txtTuto2,proximo2,anterior2, tuto3, txtTuto3, proximo3, anterior3 ,tuto4, txtTuto4, proximo4, anterior4, tuto5, txtTuto5, proximo5, anterior5 ,tuto6 , txtTuto6, proximo6, anterior6,tuto7, txtTuto7, anterior7, lojaTuto , proximoLoja, anteriorLoja;
    public void anteriorTuto(string tutoNumber)
    {
        switch (tutoNumber)
        {

            case "tuto2":
                tuto2.SetActive(false);
                txtTuto2.SetActive(false);
                proximo2.SetActive(false);
                anterior2.SetActive(false);
                tuto1.SetActive(true);
                txtTuto1.SetActive(true);
                proximo1.SetActive(true);
                break;
            case "lojaTuto":
                lojaTuto.SetActive(false);
               
                proximoLoja.SetActive(false);
                anteriorLoja.SetActive(false);
                tuto2.SetActive(true);
                txtTuto2.SetActive(true);
                proximo2.SetActive(true);
                anterior2.SetActive(true);

                break;
            case "tuto3":
                tuto3.SetActive(false);
                txtTuto3.SetActive(false);
                proximo3.SetActive(false);
                anterior3.SetActive(false);
                lojaTuto.SetActive(true);

                proximoLoja.SetActive(true);
                anteriorLoja.SetActive(true);

                break;
            case "tuto4":
                tuto4.SetActive(false);
                txtTuto4.SetActive(false);
                proximo4.SetActive(false);
                anterior4.SetActive(false);
                tuto3.SetActive(true);
                txtTuto3.SetActive(true);
                proximo3.SetActive(true);
                anterior3.SetActive(true);

                break;
            case "tuto5":
                tuto5.SetActive(false);
                txtTuto5.SetActive(false);
                proximo5.SetActive(false);
                anterior5.SetActive(false);
                tuto4.SetActive(true);
                txtTuto4.SetActive(true);
                proximo4.SetActive(true);
                anterior4.SetActive(true);
                break;
            case "tuto6":
                tuto6.SetActive(false);
                txtTuto6.SetActive(false);
                proximo6.SetActive(false);
                anterior6.SetActive(false);
                tuto5.SetActive(true);
                txtTuto5.SetActive(true);
                proximo5.SetActive(true);
                anterior5.SetActive(true);
                break;
            case "tuto7":
                tuto7.SetActive(false);
                txtTuto7.SetActive(false);
                jogarB.SetActive(false);
                anterior7.SetActive(false);
                tuto6.SetActive(true);
                txtTuto6.SetActive(true);
                proximo6.SetActive(true);
                anterior6.SetActive(true);
                break;

            default:
                break;
        }
    }


        public void nextTuto(string tutoNumber1)
    {
        switch (tutoNumber1)
        {
            case "tuto1":
                tuto1.SetActive(false);
                txtTuto1.SetActive(false);
                proximo1.SetActive(false);
               
                tuto2.SetActive(true);
                txtTuto2.SetActive(true);
                proximo2.SetActive(true);
                anterior2.SetActive(true);
                break;
            case "tuto2":
                tuto2.SetActive(false);
                txtTuto2.SetActive(false);
                proximo2.SetActive(false);
                anterior2.SetActive(false);
                lojaTuto.SetActive(true);
                
                proximoLoja.SetActive(true);
                anteriorLoja.SetActive(true);
                break;
            case "lojaTuto":
                lojaTuto.SetActive(false);
                proximoLoja.SetActive(false);
                anteriorLoja.SetActive(false);

                tuto3.SetActive(true);
                txtTuto3.SetActive(true);
                proximo3.SetActive(true);
                anterior3.SetActive(true);
                break;
            case "tuto3":
                tuto3.SetActive(false);
                txtTuto3.SetActive(false);
                proximo3.SetActive(false);
                anterior3.SetActive(false);
                tuto4.SetActive(true);
                txtTuto4.SetActive(true);
                proximo4.SetActive(true);
                anterior4.SetActive(true);
                break;
            case "tuto4":
                tuto4.SetActive(false);
                txtTuto4.SetActive(false);
                proximo4.SetActive(false);
                anterior4.SetActive(false);
                tuto5.SetActive(true);
                txtTuto5.SetActive(true);
                proximo5.SetActive(true);
                anterior5.SetActive(true);
                break;
            case "tuto5":
                tuto5.SetActive(false);
                txtTuto5.SetActive(false);
                proximo5.SetActive(false);
                anterior5.SetActive(false);
                tuto6.SetActive(true);
                txtTuto6.SetActive(true);
                proximo6.SetActive(true);
                anterior6.SetActive(true);
                break;
            case "tuto6":
                tuto6.SetActive(false);
                txtTuto6.SetActive(false);
                proximo6.SetActive(false);
                anterior6.SetActive(false);
                tuto7.SetActive(true);
                txtTuto7.SetActive(true);
                jogarB.SetActive(true);
                
                anterior7.SetActive(true);
                break;
            default:
                break;
        }
    }
}
