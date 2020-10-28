using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip button, erro, correct;
    static AudioSource audioSrc;
    void Start()
    {


        correct = Resources.Load<AudioClip>("Correct Answer Sound Effect");
        button = Resources.Load<AudioClip>("Button");
        erro = Resources.Load<AudioClip>("Ops");
        audioSrc = GetComponent<AudioSource>();

    }
    public static void PlaySom(string som)
    {
        switch (som)
        {
            case "Button":
                audioSrc.PlayOneShot(button);
                break;

            case "Correct":
                audioSrc.PlayOneShot(correct);
                break;

            case "Ops":
                audioSrc.PlayOneShot(erro);
                break;


            default:
                break;
        }
    }
}
