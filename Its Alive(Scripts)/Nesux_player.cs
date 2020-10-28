using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Nesux_player : MonoBehaviour
{
   
    

        public GameObject lifeHUD, vidatxt;
        public Text forca_txt, vida_txt;
        public GameObject teste;
        public Image fillColor;
        public Slider health_bar;
        public Slider health_bar_HUD;


       
       
        public Transform castPoint;
       
        public float  atkCD;
        
        public float test;


        public float distanceatk;
        public bool tocou;

        public Spawn Spawn;
   /* IEnumerator wait()
    {

        GameObject tempfac2 = GameObject.Find("life2");
        GameObject tempfac3 = GameObject.Find("vida2");

        yield return new WaitForSeconds(150 * Time.deltaTime);



        Destroy(tempfac2);
        Destroy(tempfac3);

        test = 0;
    }
    private void OnMouseExit()
        {
        StartCoroutine(wait());
    }

     /*   private void OnMouseDown()
        {


            test += 1;
          
            
            
            ///////////////////////////////////////////////////////////////////////////////////////////
            GameObject TempPrefab2 = Instantiate(lifeHUD) as GameObject;
            TempPrefab2.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            TempPrefab2.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);
            TempPrefab2.gameObject.name = "life" + test;
            if (TempPrefab2.gameObject.name != "life2")
            {
                Destroy(TempPrefab2);
            }
            health_bar_HUD.maxValue = this.gameObject.GetComponent<Nesux_player>().health_bar.maxValue;
            health_bar_HUD.value = this.gameObject.GetComponent<Nesux_player>().health_bar.value;
            /////////////////////////////////////////////////////////////////////////////////////////////////
            GameObject TempPrefab3 = Instantiate(vidatxt) as GameObject;
            TempPrefab3.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
            TempPrefab3.transform.SetParent(GameObject.FindGameObjectWithTag("canvas2").transform, false);
            TempPrefab3.gameObject.name = "vida" + test;
            if (TempPrefab3.gameObject.name != "vida2")
            {
                Destroy(TempPrefab3);
            }
            vida_txt.text = "" + this.gameObject.GetComponent<Nesux_player>().health_bar.value + "/" + this.gameObject.GetComponent<Nesux_player>().health_bar.maxValue;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////



        }*/




        public float currentArmor;

        public float currentLife;

        public AudioClip hit;
        AudioSource audioscr;
        void Start()
        {


            
           
           
            audioscr = GetComponent<AudioSource>();
            
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

              


                default:
                    break;
            }
        }
        // Update is called once per frame
      
        private void Update()
        {
        if (GameManager.turno == "fase de combate")
        {
            if (CanSee(distanceatk) == "inimigo")
            {

                GameManager.bateuNexusP = true;

                baternoenemy();

            }

        }

        if (this.health_bar.value <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("tela derrota");
        }







        posiPlayer.y = transform.position.y;
        posiPlayer.x = transform.position.x + 3;
        posiPlayer.z = transform.position.z;




        atkCD -= Time.deltaTime;
            







        }
   public GameObject floatinpoints;
    Vector3 posiPlayer;
        void baternoenemy()
        {
            if (atkCD <= 0f)
            {
                PlaySom("hit");
            GameObject points = Instantiate(floatinpoints, posiPlayer, Quaternion.identity) as GameObject;
            points.gameObject.name = "popup";
            transform.SetParent(GameObject.FindGameObjectWithTag("selecao").transform, false);
            points.GetComponent<TextMesh>().text = "-10";
            Destroy(points, 0.5f);
            float castdist = distanceatk;
            Vector2 endpos = castPoint.position + Vector3.right * distanceatk;
            RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {

                if (hit.collider.gameObject.CompareTag("inimigo"))
                {

                    hit.collider.gameObject.GetComponent<Enemy_combat>().health_bar.value -= 10;


                }



            }


           
                
                atkCD = 1f / 3;
            }




        }
        public float atk_speed_enemy;
        public float force_enemy;
        string CanSee(float distancia)
        {
            string val = "";

            float castdist = distancia;
            Vector2 endpos = castPoint.position + Vector3.right * distancia;
            RaycastHit2D hit = Physics2D.Linecast(castPoint.position, endpos, 1 << LayerMask.NameToLayer("Action"));
            if (hit.collider != null)
            {
                 if (hit.collider.gameObject.CompareTag("inimigo"))
                {
                    atk_speed_enemy = hit.collider.gameObject.GetComponent<Enemy_combat>().atkspeed;
                    force_enemy = hit.collider.gameObject.GetComponent<Enemy_combat>().force;
                    val = "inimigo";
                }


            }
            
            return val;
        }


    }
