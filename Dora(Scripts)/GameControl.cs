using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameControl : MonoBehaviour
{
    public GameObject block;
    public GameObject congrats;
    public GameObject pigTXT;
    public GameObject monkeyTXT;
    public GameObject sheepTXT;
    public GameObject next1;
    public GameObject next2;
    public GameObject next3;
    public GameObject ops;
    public GameObject erroSheep;
    public GameObject erroMonkey;
    public GameObject erroPig;


    public void again()
    {
        SoundManager.PlaySom("Button");
        ops.SetActive(false);
        block.SetActive(false);
    }
    public void erro()
    {
        ops.SetActive(true);
        block.SetActive(true);
        SoundManager.PlaySom("Ops");
    }

    public void ButtonNext1()
    {
        SoundManager.PlaySom("Button");
        congrats.SetActive(false);
        next1.SetActive(false);
        pigTXT.SetActive(true);
        monkeyTXT.SetActive(false);
        block.SetActive(false);




    }
    public void ButtonNext2()
    {
        SoundManager.PlaySom("Button");
        congrats.SetActive(false);
        next2.SetActive(false);
        sheepTXT.SetActive(true);
        pigTXT.SetActive(false);
        block.SetActive(false);

    }
    public void ButtonAnimal(string animal)
    {
        switch (animal)
        {
            case "Monkey":
                SoundManager.PlaySom("Correct");
                congrats.SetActive(true);
                next1.SetActive(true);
                erroMonkey.SetActive(true);
                erroPig.SetActive(false);
                block.SetActive(true);
               
               
                break;
            case "Pig":
                SoundManager.PlaySom("Correct");
                congrats.SetActive(true);
                next2.SetActive(true);
                erroPig.SetActive(true);
                erroSheep.SetActive(false);
                block.SetActive(true);


                break;
            case "Sheep":
                SoundManager.PlaySom("Correct");
                congrats.SetActive(true);
                next3.SetActive(true);
                block.SetActive(true);

                break;

            default:
                break;
        }
    }
}
