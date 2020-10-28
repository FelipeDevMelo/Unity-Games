using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    static AudioSource audioSrc;
    public AudioClip taken;
    public AudioClip pausin;

    public void pause()
    {
        buttonPause.SetActive(false);
        Time.timeScale = 1;
    }

    public float MoveSpeed;
    private Rigidbody2D RBavatar;
    private SpriteRenderer rend;
    public static  float LifeMetal;
    public static float LifePapel;
    public static float LifeVidro;
    public static float LifePlastico;
    public  float Ipapel;
    public  float Iplastico;
    public  float Imetal;
    public  float Ividro;
    public static float papel;
    public static float plastico;
    public static float metal;
    public static float vidro;
    private Animator anime;
    public  GameObject buttonPause;
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        
           switch (collision.gameObject.tag)
        {
            case "Metal":
                
                Imetal += 0.10f;
                metal += 1;
                audioSrc.PlayOneShot(taken);
                break;
            case "Papel":
                
                Ipapel += 0.10f;
                papel += 1;
                audioSrc.PlayOneShot(taken);
                break;
            case "Vidro":
                
                Ividro += 0.10f;
                vidro += 1;
                audioSrc.PlayOneShot(taken);
                break;
            case "Plastico":
                Iplastico += 0.10f;
                plastico += 1;
                audioSrc.PlayOneShot(taken);

                break;
            case "CG":
                LifeVidro += Ividro;
                Ividro =0;
                vidro = 0;
                UI.barraLife.fillAmount -= LifeVidro;
                audioSrc.PlayOneShot(taken);
                LifeVidro = 0;

                break;
            case "CY":
                LifeMetal += Imetal;
                Imetal = 0;
                metal = 0;
                UI.barraLife.fillAmount -= LifeMetal;
                audioSrc.PlayOneShot(taken);
                LifeMetal = 0;
                break;
            case "CR":
                LifePlastico += Iplastico;
                Iplastico = 0;
                plastico = 0;
                UI.barraLife.fillAmount -= LifePlastico;
                audioSrc.PlayOneShot(taken);
                LifePlastico = 0;
                break;

            case "CB":
                LifePapel += Ipapel;
                Ipapel = 0;
                papel = 0;
                UI.barraLife.fillAmount -= LifePapel;
                audioSrc.PlayOneShot(taken);
                LifePapel = 0;
                break;


            default:
                break;
        }




    }
    
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        RBavatar = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
    }
    Vector2 movement;
    private void FixedUpdate()
    {
        RBavatar.MovePosition(RBavatar.position + movement * MoveSpeed*Time.deltaTime);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            audioSrc.PlayOneShot(pausin);
            buttonPause.SetActive(true);
            Time.timeScale = 0;
        }
        anime.SetFloat("Horizontal", movement.x);
        anime.SetFloat("Vertical", movement.y);
        anime.SetFloat("Speed", movement.sqrMagnitude);
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
    }
}
