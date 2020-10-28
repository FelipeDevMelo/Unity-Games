using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public static AudioClip Coin, Explosion;
    static AudioSource audioSrc;
    void Start()
    {


        
        Explosion = Resources.Load<AudioClip>("Explosion");
        Coin = Resources.Load<AudioClip>("coin");
        audioSrc = GetComponent<AudioSource>();
       
    }
    public static void  PlaySom(string som)
    {
        switch (som)
        {
            case "coin":
                audioSrc.PlayOneShot(Coin);
                break;

            case"Explosion":
                audioSrc.PlayOneShot(Explosion);
                break;
            

            default:
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
