using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_controller : MonoBehaviour
{
    public Animator cortina;
    // Start is called before the first frame update
    void Start()
    {
        audioscr = GetComponent<AudioSource>();
    }
    public AudioClip vuf;
    AudioSource audioscr;
    IEnumerator wait(string cena)
    {
        audioscr.PlayOneShot(vuf);
        cortina.SetBool("iniciar_rodada", true);
        yield return new WaitForSeconds(4f);
        cortina.SetBool("iniciar_rodada", false);
        audioscr.PlayOneShot(vuf);
        SceneManager.LoadScene(cena);
    }

    public void sair()
    {
        Application.Quit();
    }
    public void multiNTN()
    {
        GameManager.multiplayer = true;
    }

    public void SingleNTN()
    {
        GameManager.multiplayer = false;
    }
    public  void menubtn(string cen)
    {

        StartCoroutine(wait(cen));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
