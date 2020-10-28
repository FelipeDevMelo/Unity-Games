using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_combat : MonoBehaviour
{
    public float armadura;
    public GameObject teste;
    public Slider health_bar_HUD;
    public GameObject lifeHUD, vidatxt, atkspdTXT;
    public Text forca_txt, vida_txt, atkspd_txt;
    public Image fillColor;
    public float force;
    public Slider health_bar;
    public Slider armor_bar;
   public Transform castPoint;
    bool taNoRange;
    Rigidbody2D rbjogador;
    public float atkspeed, atkCD, atkCD2;
    Animator animator;
    float test;
    public float distanceatk;
    
    private void OnMouseExit()
    {
        
    }

    private void OnMouseDown()
    {


      

    }

    public Spawn Spawn;



    bool fila ;
    public float currentArmor;
    
    public float currentLife;
   

    public AudioClip hit, dmg;
    AudioSource audioscr;
    void Start()
    {
      
        taNoRange = false;
        rbjogador = GetComponent<Rigidbody2D>();
        atkspeed = 1f;
        audioscr = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        animator.SetBool("fila", true);
    }
    void andar()
    {
        rbjogador.velocity = new Vector2(-40 * Time.deltaTime, 0);
    }

    void parar()
    {
        rbjogador.velocity = new Vector2(0, 0);
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
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
        yield return new WaitForSeconds(25 * Time.deltaTime);
        baterplayer();
    }
    private void Update()
    {


       
        
        if (health_bar.value <= 0)
        {
            GameManager.bodycount -= 1;
            Destroy(this.gameObject);
        }
        if (GameManager.turno == "fase de combate")
        {
             if (CanSee(distanceatk) == "inimigo")
        {

            taNoRange = true;
            animator.SetBool("bateu", true);
            animator.SetBool("fila", false);
                baterplayer();


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
                baterplayer();
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

        posiPlayer.y = transform.position.y + 2;
        posiPlayer.x = transform.position.x - 1;
        posiPlayer.z = transform.position.z;

        atkCD -= Time.deltaTime;
        atkCD2 -= Time.deltaTime;
        animator.speed = atkspeed;


        


    }
    Vector3 posiPlayer;
    void baternoenemy2()
    {
       /* if (atkCD2 <= 0f)
        {
            PlaySom("hit");
            PlaySom("dmg");

            float castdist = distanceatk;
            Vector2 endpos = castPoint2.position + Vector3.right * distanceatk;
            RaycastHit2D hit = Physics2D.Linecast(castPoint2.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {

                if (hit.collider.gameObject.CompareTag("player"))
                {

                    hit.collider.gameObject.GetComponent<Player_combat>().health_bar.value -= force;


                }



            }




            atkCD2 = 1f / atkspeed;
        }*/
       
    }
    public GameObject floatinpoints;
    void baterplayer()
    {

        if (atkCD <= 0f)
        {

            PlaySom("hit");
            PlaySom("dmg");
            GameObject points = Instantiate(floatinpoints, posiPlayer, Quaternion.identity) as GameObject;
            points.gameObject.name = "popup";
            transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
            points.GetComponent<TextMesh>().text = "-"+force.ToString();
            Destroy(points, 0.5f);
            float castdist = distanceatk;
            Vector2 endpos = castPoint.position + Vector3.right * distanceatk;
            RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {

                if (hit.collider.gameObject.CompareTag("player"))
                {

                    hit.collider.gameObject.GetComponent<Player_combat>().health_bar.value -= (force - armor_enemy);


                }
                else if (hit.collider.gameObject.CompareTag("nexus_player"))
                {

                    hit.collider.gameObject.GetComponent<Nesux_player>().health_bar.value -= force;
                }


            }


            

            atkCD = 1f / atkspeed;
        }
    }


    public float armor_enemy;
    public float atk_speed_player;
    string CanSee(float distancia)
    {
        string val = "";
      
        float castdist = distancia;
        Vector2 endpos = castPoint.position + Vector3.left * distancia;
        RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
        
        if (hit.collider != null)
        {
           
            if (hit.collider.gameObject.CompareTag("player"))
            {
                atk_speed_player = hit.collider.gameObject.GetComponent<Player_combat>().atkspeed;
                armor_enemy = hit.collider.gameObject.GetComponent<Player_combat>().armadura;
                val ="inimigo";
            }
            else if (hit.collider.gameObject.CompareTag("inimigo"))
            {
                val = "aliado";
            }
            else if (hit.collider.gameObject.CompareTag("nexus_player"))
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







