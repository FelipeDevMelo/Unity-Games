using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour
{
    public Swipe swipeControl;
    public Transform player;
    public Rigidbody playerRB;
   
    void Update()
    {
        if (swipeControl.SwipeLeft)
        {
            
            playerRB.AddForce(new Vector3(-120000f * Time.deltaTime, 0, 0));
            
           
        }
        if (swipeControl.SwipeRight)
        {
            playerRB.AddForce(new Vector3(+120000f * Time.deltaTime, 0, 0));
                     

        }
                     
    }
    
}
