using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level_manager : MonoBehaviour
{
    [System.Serializable]
    public class Level
    {
        public string levelText;
        public bool habilitado;
        public int desbloqueado;
        public bool txtAtivo;
    }
    public GameObject botao;
    public Transform localBTN;
    public List<Level> levelList;

    void ListaAdd()
    {
        foreach (Level lvl in levelList )
        {
            GameObject btnNovo = Instantiate(botao) as GameObject;
            Botao_level btnNew = btnNovo.GetComponent<Botao_level>();
            btnNew.levelTxtBtn.text = lvl.levelText;
            if (PlayerPrefs.GetInt("Level"+ btnNew.levelTxtBtn.text)==1)
            {
                lvl.desbloqueado = 1;
                lvl.habilitado = true;
                lvl.txtAtivo = true;
            }
            btnNew.desbloqueadoBtn = lvl.desbloqueado;
            btnNew.GetComponent<Button>().interactable = lvl.habilitado;
            btnNew.GetComponentInChildren<Text>().enabled = lvl.txtAtivo;
            btnNew.GetComponent<Button>().onClick.AddListener(() => ClickLevel("fase_" + btnNew.levelTxtBtn.text));
            btnNovo.transform.SetParent(localBTN, false);
        }
    }

    void ClickLevel(string level)
    {
        SceneManager.LoadScene(level);  
    }
    void Start()
    {
       // PlayerPrefs.DeleteAll();
        ListaAdd();
    }
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
