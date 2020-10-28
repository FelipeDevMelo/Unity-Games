using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bola_Control : MonoBehaviour
{
    
    
    public float zRotate;
    public bool liberaRot = false;
    public bool liberaTiro;
    public GameObject setaGo;
    private Transform paredeLD,paredeLE;
    private Rigidbody2D bola;
    private float forc = 700f;


    public Image seta2;

    void BolaDinamica()
    {
        this.gameObject.GetComponent<Rigidbody2D>().isKinematic = false; 
    }
    private void Awake()
    {
       
        setaGo = GameObject.Find("seta");
        seta2 = GameObject.Find("seta2").GetComponent<Image>();
        setaGo.GetComponent<Image>().enabled = false;
        seta2.GetComponent<Image>().enabled = false;
        paredeLD = GameObject.Find("WallRight").GetComponent<Transform>();
        paredeLE = GameObject.Find("WallLeft").GetComponent<Transform>();
    }
    void Paredes()
    {
        if (this.gameObject.transform.position.x > paredeLD.position.x)
        {
            Destroy(this.gameObject);
            Game_Manager.instance.bolasEmCena -= 1;
            Game_Manager.instance.bolasNum -= 1;
        }

        if (this.gameObject.transform.position.x < paredeLE.position.x)
        {
            Destroy(this.gameObject);
            Game_Manager.instance.bolasEmCena -= 1;
            Game_Manager.instance.bolasNum -= 1;
        }
    }
    void Start()
    {

        
        bola = GetComponent<Rigidbody2D>();
        

        
    }

   
    void Update()
    {
        Paredes();
        ControlaForca();
        AplicaForca();
        PosiiconaSeta();
        limitRotacion();
        InputRotacion();
        RotationSeta();
    }
    void PosiiconaSeta()
    {
        setaGo.GetComponent<Image>().rectTransform.position = transform.position;
    }
  
    void RotationSeta()
    {
        setaGo.GetComponent<Image>().rectTransform.eulerAngles = new Vector3(0, 0, zRotate);
    }
    void InputRotacion()
    {
        if (liberaRot == true)
        {

            float moveY = Input.GetAxis("Mouse Y");
            if (zRotate < 90)
            {
                if (moveY < 0)
                {
                    zRotate += 2.5f;
                }

            }
            if (zRotate > 0)
            {
                if (moveY > 0)
                {
                    zRotate -= 2.5f;
                }
            }


        }



    }
    void limitRotacion()
    {
        if (zRotate >= 90)
        {
            zRotate = 90;
        }
        if (zRotate <= 0)
        {
            zRotate = 0;
        }
    }

    private void OnMouseDown()
    {
        if (Game_Manager.instance.tiro==0)
        {
            setaGo.GetComponent<Image>().enabled = true;
            seta2.GetComponent<Image>().enabled = true;
            liberaRot = true;
        }
        
    }
    private void OnMouseUp()
    {
        
        liberaRot = false;
        setaGo.GetComponent<Image>().enabled = false;
        seta2.GetComponent<Image>().enabled = false;
        if (Game_Manager.instance.tiro==0 && forc >0)
        {
            seta2.fillAmount = 0;
            Audio_manager.instance.SonsFXToca(1);
            Game_Manager.instance.tiro = 1;
            liberaTiro = true;
        }
      
    }

    void AplicaForca()
    {
        float x = forc * Mathf.Cos(zRotate * Mathf.Deg2Rad);
        float y = forc * Mathf.Sin(zRotate * Mathf.Deg2Rad);
        if (liberaTiro == true)
        {
            bola.AddForce(new Vector2(x, y));
            liberaTiro = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("win"))
        {
            Game_Manager.instance.win = true;
        }
        if (collision.gameObject.CompareTag("morte"))
        {
            Destroy(this.gameObject);
            Game_Manager.instance.bolasEmCena -= 1;
            Game_Manager.instance.bolasNum -= 1;
        }     
    }
    void ControlaForca()
    {
        if (liberaRot == true)
        {
            float moveX = Input.GetAxis("Mouse X");
            if (moveX < 0)
            {
                seta2.fillAmount += 1 * Time.deltaTime;
                forc = seta2.fillAmount * 1000;
            }
            if (moveX > 0)
            {
                seta2.fillAmount -= 1f * Time.deltaTime;
                forc = seta2.fillAmount * 1000;
            }
        }
    }
}
