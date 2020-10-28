using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Maanager : MonoBehaviour
{
    public static UI_Maanager instance;
    public Text pontos_UI,bolas_UI;
    private GameObject lose_Painel, win_Painel, pause_Painel;
    [SerializeField]
    private Button pauseBTN,pauseBTNr,btnRetry,btnMenu;

    public int moedasNumAntes,moedasNumDepois,resultado;



    private void Awake()
    {
        
        if (instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        SceneManager.sceneLoaded += Carrega;
    }
    public void updateUI()
    {
        pontos_UI.text = Score_manager.instancia.moedas.ToString();
        bolas_UI.text = Game_Manager.instance.bolasNum.ToString();
        moedasNumDepois = Score_manager.instancia.moedas;
    }
    void Carrega(Scene cena , LoadSceneMode modo)
    {
        if (OndeEstou.instance.fase!=4)
        {
            pause_Painel = GameObject.Find("pause_painel ");
            win_Painel = GameObject.Find("Win_painel");
            lose_Painel = GameObject.Find(" Lose_painel");
            pontos_UI = GameObject.Find("pontos_UI").GetComponent<Text>();
            bolas_UI = GameObject.Find("bolas_UI").GetComponent<Text>();
            pauseBTN = GameObject.Find("Pause_BTN").GetComponent<Button>();
            pauseBTNr = GameObject.Find("Return_BTN").GetComponent<Button>();
            btnRetry = GameObject.Find("Retry_BTN_lose").GetComponent<Button>();
            btnMenu = GameObject.Find("Menufases_btn").GetComponent<Button>();
            LigaDesligaPainel();

            pauseBTN.onClick.AddListener(Pause);
            pauseBTNr.onClick.AddListener(ReturnPause);
            btnMenu.onClick.AddListener(Levels);
            btnRetry.onClick.AddListener(JogarNovamente);

            moedasNumAntes = PlayerPrefs.GetInt("moedasSave");
        }
       
    }

   public void GameOver_UI()
    {
        lose_Painel.SetActive(true);
    }

    void LigaDesligaPainel()
    {
        StartCoroutine(tempo());  
    }
    IEnumerator tempo()
    {
        yield return new WaitForSeconds(0.001f);
        lose_Painel.SetActive(false);
        win_Painel.SetActive(false);
        pause_Painel.SetActive(false);
    }
    public void WinGameUI()
    {
        win_Painel.SetActive(true);
    }
   public void StartUI()
    {
        LigaDesligaPainel();
    }
    IEnumerator EsperaPause()
    {
        yield return new WaitForSeconds(0.3f);
        pause_Painel.SetActive(false);
    }
    void ReturnPause()
    {
        Time.timeScale = 1;
        pause_Painel.GetComponent<Animator>().Play("Pause_painelR");
        
       
        StartCoroutine(EsperaPause()); 
    }
    void Pause()
    {
        pause_Painel.SetActive(true);
        pause_Painel.GetComponent<Animator>().Play("Pause_painel");
        Time.timeScale = 0 ;
    }
    void JogarNovamente()
    {
       
        if (Game_Manager.instance.win==false)
        {
            SceneManager.LoadScene(OndeEstou.instance.fase);
            resultado = moedasNumDepois - moedasNumAntes;
            Score_manager.instancia.PerdeMoedas(resultado);
            resultado = 0;
        }
        else
        {
            SceneManager.LoadScene(OndeEstou.instance.fase);
            resultado = 0;
        }
       
    }

    void Levels()
    {
        if (Game_Manager.instance.win == false)
        {
            SceneManager.LoadScene(OndeEstou.instance.fase);
            resultado = moedasNumDepois - moedasNumAntes;
            Score_manager.instancia.PerdeMoedas(resultado);
            resultado = 0;
            SceneManager.LoadScene(4);
        }
        else
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
