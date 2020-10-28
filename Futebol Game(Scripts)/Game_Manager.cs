using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public static Game_Manager instance;
    [SerializeField]
    private GameObject bola;
    public int bolasNum = 2;
    private bool bolaMorreu = false;
    public int bolasEmCena = 0;
    private Transform pos;
    public int tiro = 0;
    public bool win;
    public int ondeEstou;
    public bool jogoComecou;

    void GameOver()
    {
        jogoComecou = false;
        UI_Maanager.instance.GameOver_UI();
    }
    void NascBolas()
    {
        if (bolasNum >0 && bolasEmCena == 0)
        {
            Instantiate(bola, new Vector2(pos.position.x, pos.position.y), Quaternion.identity);
            bolasEmCena += 1;
            tiro = 0;
        }
    }
    private void Awake()
    {
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        SceneManager.sceneLoaded += Carrega;
    }
    void Start()
    {
        Score_manager.instancia.GameStartScoreM();
    }
    void Carrega(Scene cena, LoadSceneMode modo)

    {
        if (OndeEstou.instance.fase !=4)
        {
            StartGame();
            
            pos = GameObject.Find("Posi_start").GetComponent<Transform>();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (win)
        {
            WinGame(); 
        }
        NascBolas();
        if (bolasNum<=0)
        {
            GameOver();
        }
        Score_manager.instancia.UpdateScore();
        UI_Maanager.instance.updateUI();
    }
    void WinGame()
    {

        jogoComecou = false;
        UI_Maanager.instance.WinGameUI();
    }

    void StartGame()
    {
        jogoComecou = true;
        bolasNum = 2;
        bolasEmCena = 0;
        UI_Maanager.instance.StartUI();
        win = false;
    }
}
