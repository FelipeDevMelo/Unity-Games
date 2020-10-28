using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Status_view : MonoBehaviour
{
  
    public Image[] posshape;
    public  float energiaFrank, energiaVlad, energiaThori;
    public GameObject player;
    public Spawn spawn;
    public GameObject balaoFrankHead;
   public static int preenchimento=0;
    private void Awake()
    {
        energiaFrank = 0;
    }
    void Start()
    {
        preenchimento = 0;
    }
    public void resetarBalao()
    {
        GameObject[] balaos2;
        balaos2 = GameObject.FindGameObjectsWithTag("balao");

        foreach (GameObject balao in balaos2)
        {
            Destroy(balao);
        }
    }
    public void comprarFrankHead()
    {

      

        if (GameManager.energiaAtual >= 14 )
        {
            
            GameObject TempPrefab = Instantiate(spawn.head[1]) as GameObject;
            TempPrefab.transform.position = posshape[0].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_head").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeHead = "cabeça_FRank";
            GameManager.nomeHead_status = "cabeça_FRank";
            preenchimento += 1;
            resetarBalao();
            GameManager.energiaAtual -= 14;
            
            
        }
        
    }

    public void comprarFrankbody()
    {
        if (GameManager.energiaAtual >= 38)
        {
        GameObject TempPrefab = Instantiate(spawn.body[2]) as GameObject;
        TempPrefab.transform.position = posshape[1].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_body").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeBody = "torso_FRank";
        GameManager.nomeBody_status = "torso_FRank";
            preenchimento += 1;
            GameManager.energiaAtual -= 38;
            resetarBalao();

        }
        
    }
    public void comprarFrankLeg()
    {
        if (GameManager.energiaAtual >= 26)
        {

GameObject TempPrefab = Instantiate(spawn.leg[1]) as GameObject;
            TempPrefab.transform.position = posshape[4].rectTransform.position;
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_leg").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLegs = "pernas_FRank";
            GameManager.nomeLegs_status = "pernas_FRank";
            GameManager.energiaAtual -= 26;
            preenchimento += 1;
            resetarBalao();
        }
        
    }

    public void comprarFrankLarm()
    {
        if (GameManager.energiaAtual >= 18)
        {
  GameObject TempPrefab = Instantiate(spawn.armL[1]) as GameObject;
            TempPrefab.transform.position =posshape[2].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BE").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLarm = "braço_FRankL";
        GameManager.nomeLarm_status = "braço_FRankL";
            preenchimento += 1;
            GameManager.energiaAtual -= 18;

            resetarBalao();
        }
      
    }

    public void comprarFrankRarm()
    {
        if (GameManager.energiaAtual >= 18)
        {

 GameObject TempPrefab = Instantiate(spawn.armR[1]) as GameObject;
        TempPrefab.transform.position = posshape[3].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BD").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeRarm = "braço_frankR";
        GameManager.nomeRarm_status = "braço_frankR";
            GameManager.energiaAtual -= 18;
            resetarBalao();
            preenchimento += 1;
        }
       
    }

    public void comprarThoriHead()
    {
        if (GameManager.energiaAtual >= 14)
        {

GameObject TempPrefab = Instantiate(spawn.head[2]) as GameObject;
            TempPrefab.transform.position = posshape[0].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_head").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeHead = "cabeça_tauro";
        GameManager.nomeHead_status = "cabeça_tauro";
            GameManager.energiaAtual -= 14;
            preenchimento += 1;
            resetarBalao();
        }
        
    }

    public void comprarThoribody()
    {
        if (GameManager.energiaAtual >= 20)
        {
GameObject TempPrefab = Instantiate(spawn.body[0]) as GameObject;
            TempPrefab.transform.position = posshape[1].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_body").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeBody = "torso_tauro";
        GameManager.nomeBody_status = "torso_tauro";

            GameManager.energiaAtual -= 20;
            preenchimento += 1;
            resetarBalao();
        }
        
    }
    public void comprarThoriLeg()
    {
        if (GameManager.energiaAtual >= 21)
        {
 GameObject TempPrefab = Instantiate(spawn.leg[2]) as GameObject;
            TempPrefab.transform.position = posshape[4].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_leg").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLegs = "pernas_tauro";
        GameManager.nomeLegs_status = "pernas_tauro";

            GameManager.energiaAtual -= 21;
            preenchimento += 1;
            resetarBalao();
        }
       
    }

    public void comprarThoriLarm()
    {
        if (GameManager.energiaAtual >= 11)
        {
 GameObject TempPrefab = Instantiate(spawn.armL[2]) as GameObject;
            TempPrefab.transform.position = posshape[2].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BE").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLarm = "braço_tauroL";
        GameManager.nomeLarm_status = "braço_tauroL";

            GameManager.energiaAtual -= 11;
            preenchimento += 1;
            resetarBalao();
        }
       
    }

    public void comprarThoriRarm()
    {
        if (GameManager.energiaAtual >= 9)
        {
GameObject TempPrefab = Instantiate(spawn.armR[2]) as GameObject;
            TempPrefab.transform.position = posshape[3].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BD").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeRarm = "braço_tauroR";
        GameManager.nomeRarm_status = "braço_tauroR";
            resetarBalao();
            GameManager.energiaAtual -= 9;
            preenchimento += 1;

        }
        
    }


    public void comprarVladHead()
    {
        if (GameManager.energiaAtual >= 10)
        {

GameObject TempPrefab = Instantiate(spawn.head[0]) as GameObject;
            TempPrefab.transform.position = posshape[0].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_head").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeHead = "cabeça_gato";
        GameManager.nomeHead_status = "cabeça_gato";
            GameManager.energiaAtual -= 10;
            resetarBalao();
            preenchimento += 1;
        }
        
    }

    public void comprarVladbody()
    {
        if (GameManager.energiaAtual >= 15)
        {

GameObject TempPrefab = Instantiate(spawn.body[1]) as GameObject;
            TempPrefab.transform.position = posshape[1].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_body").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeBody = "troso_gato";
        GameManager.nomeBody_status = "troso_gato";
            GameManager.energiaAtual -= 15;
            resetarBalao();
            preenchimento += 1;
        }
        
    }
    public void comprarVladLeg()
    {
        if (GameManager.energiaAtual >= 8)
        {

 GameObject TempPrefab = Instantiate(spawn.leg[0]) as GameObject;
            TempPrefab.transform.position = posshape[4].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_leg").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLegs = "Pernas_gato";
        GameManager.nomeLegs_status = "Pernas_gato";
            GameManager.energiaAtual -= 8;
            preenchimento += 1;
            resetarBalao();
        }
       
    }

    public void comprarVladLarm()
    {
        if (GameManager.energiaAtual >= 4)
        {
GameObject TempPrefab = Instantiate(spawn.armL[0]) as GameObject;
            TempPrefab.transform.position = posshape[2].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BE").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeLarm = "braçoE_gato";
        GameManager.nomeLarm_status = "braçoE_gato";

            GameManager.energiaAtual -= 4;
            resetarBalao();
            preenchimento += 1;
        }
        
    }

    public void comprarVladRarm()
    {
        if (GameManager.energiaAtual >= 4)
        {
 GameObject TempPrefab = Instantiate(spawn.armR[0]) as GameObject;
            TempPrefab.transform.position = posshape[3].rectTransform.position;
            TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("shape_BD").transform, false);
            TempPrefab.gameObject.name = "clone";
            GameManager.nomeRarm = "braçoD_gato";
        GameManager.nomeRarm_status = "braçoD_gato";
            resetarBalao();
        }

            GameManager.energiaAtual -= 4;
        preenchimento += 1;

    }
       

    public void frankHead()
    {
        

        GameObject TempPrefab = Instantiate(balaoFrankHead) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoThoriHead;

    public void ThoriHead()
    {
        GameObject TempPrefab = Instantiate(balaoThoriHead) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoVladHead;

    public void VladHead()
    {
        GameObject TempPrefab = Instantiate(balaoVladHead) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoFrankbody;

    public void frankbody()
    {
        GameObject TempPrefab = Instantiate(balaoFrankbody) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoThoribody;

    public void Thoribody()
    {
        GameObject TempPrefab = Instantiate(balaoThoribody) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoVladbody;

    public void Vladbody()
    {
        GameObject TempPrefab = Instantiate(balaoVladbody) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoFrankArml;

    public void frankArml()
    {
        GameObject TempPrefab = Instantiate(balaoFrankArml) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoThoriArml;

    public void ThoriArml()
    {
        GameObject TempPrefab = Instantiate(balaoThoriArml) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoVladArml;

    public void VladArml()
    {
        GameObject TempPrefab = Instantiate(balaoVladArml) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoFrankArmR;

    public void frankArmR()
    {
        GameObject TempPrefab = Instantiate(balaoFrankArmR) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoThoriArmR;

    public void ThoriArmR()
    {
        GameObject TempPrefab = Instantiate(balaoThoriArmR) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoVladArmR;

    public void VladArmR()
    {
        GameObject TempPrefab = Instantiate(balaoVladArmR) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }


    public GameObject balaoFrankLeg;

    public void frankleg()
    {
        GameObject TempPrefab = Instantiate(balaoFrankLeg) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoThoriLeg;

    public void Thorileg()
    {
        GameObject TempPrefab = Instantiate(balaoThoriLeg) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public GameObject balaoVladleg;

    public void VladArmleg()
    {
        GameObject TempPrefab = Instantiate(balaoVladleg) as GameObject;
        TempPrefab.transform.position = new Vector3(62, 73, 0);
        TempPrefab.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);

    }

    public void fecharbalao()
    {


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
