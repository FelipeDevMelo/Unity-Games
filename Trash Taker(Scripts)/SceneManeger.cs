using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManeger : MonoBehaviour
{
    static AudioSource audioSrc;
    public  AudioClip Button;
    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        
    }
    public void loadScene(string nome)
    {
        SceneManager.LoadScene(nome);
       
    }

    public void Quit()
    {
        Application.Quit();

    }
    public   void toca()
    {
        audioSrc.PlayOneShot(Button);
    }
    
}
