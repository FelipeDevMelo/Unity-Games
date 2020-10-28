using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public static bool comprado1 = false, comprado2 = false;
    public GameObject skin1, skin2;
    public Animator Skins;
    public static string verificadordeSkin;
    public GameObject playButton;
    public GameObject PauseButton;
    public static bool Vitoria = false;
    public static bool Derrota = false;
    public Transform playerTransform;
    public static float moveSpeed = 6;
    public GameObject character;
    private Rigidbody2D PlayerRB;
    private float Screenw;
    public UnityEngine.UI.Text txt;
    public GameObject txtMenu;
    public static int moedas=1000;
    public static int pontos;
    private bool timeScale;
    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
    public void play()
    {
       
        
            Time.timeScale = 1;
            timeScale = false;
            txtMenu.SetActive(false);
            playButton.SetActive(false);
        PauseButton.SetActive(true);
        

    }
    public void pause()
    {
        
        
            Time.timeScale = 0;
            timeScale = false;
            txtMenu.SetActive(true);
            playButton.SetActive(true);
        PauseButton.SetActive(false);

        
       
    }
        
    void Start()
    {
        
        timeScale = true;
       
        Screenw = Screen.width;
        PlayerRB = character.GetComponent<Rigidbody2D>();
    }

    private void RunCharacter(float horizontaInput)
    {
        playerTransform.Translate( new Vector3(horizontaInput * moveSpeed * Time.deltaTime, 0));
    }
    IEnumerator LoadDerrota(float tempo)
    {

        yield return new WaitForSeconds(tempo);
        SceneManager.LoadScene("Derrota");
    }
    IEnumerator LoadVitoria(float tempo)
    {

        yield return new WaitForSeconds(tempo);
        SceneManager.LoadScene("Vitoria");
    }
    void Update()
    {
        switch (verificadordeSkin)
        {
            case "Skin1":
                skin1.SetActive(true);
                break;
            case "Skin2":
                skin2.SetActive(true);
                break;
            case "Idle":
                skin1.SetActive(false);
                skin2.SetActive(false);
                break;
            default:
                break;
        }
        if (Vitoria ==true)
        {
            StartCoroutine(LoadVitoria(0));
        }
        
        if (Derrota == true)
        {
            StartCoroutine(LoadDerrota(1));
        }
      

        if (Input.GetKey(KeyCode.A))
        {
            RunCharacter(-1.0f);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RunCharacter(1.0f);
        }
        txt.text = "Pontos : " + pontos.ToString();
        
        int i = 0;
        while (i <Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > Screenw / 2)
            {
                RunCharacter(1.0f);
            }
            if (Input.GetTouch(i).position.x < Screenw / 2)
            {
                RunCharacter(-1.0f);
            }
            ++i; 
        }
    }
}
