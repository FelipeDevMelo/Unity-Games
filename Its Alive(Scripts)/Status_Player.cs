using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status_Player : MonoBehaviour
{
    [SerializeField] public static float force, atkspd, vida, mistico, armor;
   
    public float forca,life,mystic,armadura,VelocidadeDeAtaque;
    
    void Start()
    {
        atkspd = 1;
    }
    private void LateUpdate()
    {
       
        mystic = mistico;
        armadura = armor;
        VelocidadeDeAtaque = atkspd;
        forca = force;
        life = vida;
        
    }
    // Update is called once per frame
    
}
