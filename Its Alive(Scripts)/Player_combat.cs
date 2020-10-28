using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player_combat : MonoBehaviour
{
    public int[] n_pecas;


    public GameObject lifeHUD,vidatxt,atkspdTXT , skill1_btn, skill2_btn;
    public Text forca_txt,vida_txt,atkspd_txt;
    public GameObject teste;
    public Image fillColor;
    public Slider health_bar;
    public Slider health_bar_HUD;
    public float armadura;
    bool fila; 
    
    public float force;
    public Transform castPoint,castPoint2;
    bool taNoRange;
    Rigidbody2D rbjogador;
    public float atkspeed, atkCD, atkCD2;
    Animator animator;
    public float test;


    public float distanceatk;
    public bool tocou;   

    public Spawn Spawn;

   
    private void OnMouseExit()
    {
       
    }
        
    private void OnMouseDown()
    {
       
        
       

    }

   


    public float currentArmor;
   
    public float currentLife;
   
    public AudioClip hit, dmg;
    AudioSource audioscr;
    void Start()
    {
        

        taNoRange = false;
        rbjogador = GetComponent<Rigidbody2D>();
       
        audioscr = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        animator.SetBool("fila", true);
        
    }
    void andar()
    {
        rbjogador.velocity = new Vector2(40 * Time.deltaTime, 0);
    }

    void parar()
    {
        rbjogador.velocity = new Vector2(0, 0);
    }
   
    private void OnDrawGizmosSelected()
    {

        Gizmos.DrawWireSphere(transform.position, distanceatk);
    }
    public void PlaySom(string som)
    {
        switch (som)
        {
            case "hit":
                audioscr.PlayOneShot(hit);
                break;

            case "dmg":
                
                break;


            default:
                break;
        }
    }
    // Update is called once per frame
    public void resetatd()
    {
        GameObject[] balaos;

        balaos = GameObject.FindGameObjectsWithTag("cobaia1");

        foreach (GameObject cobaia in balaos)
        {
            Destroy(cobaia);
        }
        GameObject[] balaos2;

        balaos2= GameObject.FindGameObjectsWithTag("balao");

        foreach (GameObject balao in balaos2)
        {
            Destroy(balao);
        }

        GameManager.nomeHead = null;
        GameManager.nomeLegs = null;
        GameManager.nomeBody = null;
        GameManager.nomeRarm = null;
        GameManager.nomeLarm = null;
        Status_Player.atkspd = 1;
        Status_Player.armor = 0;
        Status_Player.vida = 0;
        Status_Player.force = 0;
        Status_Player.mistico = 0;
        Combo_Efeitos.n_pecas_frank = 0;
        Combo_Efeitos.n_pecas_gato = 0;
        Combo_Efeitos.n_pecas_tauro = 0;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(26*Time.deltaTime);
        baternoenemy();
    }
   public void Skill1_frank()
    {
        Debug.Log("skill_frank");
    }
    public void Skill1_thori()
    {
        Debug.Log("skill_thori");
    }
    public GameObject popup;
    private void Update()
    {

      
       
      


        if (health_bar.value<=0)
        {
            GameManager.bodycount -= 1;
            Scene_maneger.bodyCountPlayer -= 1;
            Destroy(this.gameObject);
        }


        if (GameManager.turno == "fase de combate")
        {

            if (CanSee(distanceatk) == "inimigo")
            {

                taNoRange = true;
                animator.SetBool("bateu", true);
                animator.SetBool("fila", false);
                baternoenemy();
                

            }

            else if (CanSee(distanceatk) == "aliado")
            {
                taNoRange = true;
                animator.SetBool("fila", true);
                animator.SetBool("bateu", false);
                fila = true;

            }
            else if (CanSee(distanceatk) == "nexus")
            {
                taNoRange = true;
                animator.SetBool("bateu", true);
                animator.SetBool("fila", false);
                baternoenemy();

            }
            else if (CanSee(distanceatk) == "pode andar")
            {
                animator.SetBool("bateu", false);
                animator.SetBool("fila", false);
                taNoRange = false;
            }
            


            if (taNoRange == false)
            {
                andar();
            }
            else
            {
                parar();
            }
        }
        atkCD -= Time.deltaTime; 
        atkCD2 -= Time.deltaTime;
       animator.SetFloat("AnimMultiplier ", atkspeed);




      
        posiPlayer.y = transform.position.y + 2;
        posiPlayer.x = transform.position.x+1;
        posiPlayer.z = transform.position.z;


    }
    Vector3 posiPlayer;
    void baternoenemy2()
    {
      /*  if (atkCD2 <= 0f)
        {
            PlaySom("hit");
            PlaySom("dmg");

            float castdist = distanceatk;
            Vector2 endpos = castPoint2.position + Vector3.right * distanceatk;
            RaycastHit2D hit = Physics2D.Linecast(castPoint2.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {
                
                 if (hit.collider.gameObject.CompareTag("inimigo"))
                {
                    
                   hit.collider.gameObject.GetComponent<Enemy_combat>().health_bar.value -= force;

                   
                }
                if (hit.collider.gameObject.CompareTag("nexus_enemy"))
                {

                    hit.collider.gameObject.GetComponent<Nexus_enemy>().health_bar.value -= force;


                }



            }


            

            atkCD2 = 1f / atkspeed;
        }*/




    }
    public GameObject floatinpoints;
   
   
    void baternoenemy()
    {
        if (atkCD <= 0f)
        {
            PlaySom("hit");
            PlaySom("dmg");
           
            GameObject points = Instantiate(floatinpoints, posiPlayer, Quaternion.identity) as GameObject;
            points.gameObject.name = "popup";
            transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
            points.GetComponent<TextMesh>().text = "-" + force.ToString();

            Destroy(points, 0.5f);
          
            float castdist = distanceatk;
            Vector2 endpos = castPoint.position + Vector3.right * distanceatk;
            RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {

                if (hit.collider.gameObject.CompareTag("inimigo"))
                {

                    hit.collider.gameObject.GetComponent<Enemy_combat>().health_bar.value -= (force-armor_enemy);


                }
                else if (hit.collider.gameObject.CompareTag("nexus_enemy"))
                {

                    hit.collider.gameObject.GetComponent<Nexus_enemy>().health_bar.value -= force;
                }


            }

            
            
            atkCD = 1f / atkspeed;
        }




    }
    public float atk_speed_enemy;
    public float armor_enemy;
    string CanSee(float distancia)
    {
        string val = "";

        float castdist = distancia;
        Vector2 endpos = castPoint.position + Vector3.right * distancia;
        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("player"))
            {
               
                val = "aliado";
            }
            else if (hit.collider.gameObject.CompareTag("inimigo"))
            {
                atk_speed_enemy = hit.collider.gameObject.GetComponent<Enemy_combat>().atkspeed;
                armor_enemy = hit.collider.gameObject.GetComponent<Enemy_combat>().armadura;
                val = "inimigo";
            }
            else if (hit.collider.gameObject.CompareTag("nexus_enemy"))
            {

                val = "nexus";
            }


        }
        else
        {
            val = "pode andar";
        }
        return val;
    }

    
   
    string CanSee1(float distancia)
    {
        string val = "";

        float castdist = distancia;
        Vector2 endpos = castPoint2.position + Vector3.right * distancia;
        RaycastHit2D hit = Physics2D.Linecast(castPoint2.position, endpos, 1 << LayerMask.NameToLayer("Action"));
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.CompareTag("player"))
            {

                val = "aliado";
            }
            else if (hit.collider.gameObject.CompareTag("inimigo"))
            {
               
                
                val = "inimigo";
            }
            else if (hit.collider.gameObject.CompareTag("nexus_enemy"))
            {
                val = "nexus";
            }


        }
        else
        {
            val = "pode andar";
        }
        return val;
    }


}
