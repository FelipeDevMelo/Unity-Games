using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba_manager : MonoBehaviour
{
    [SerializeField]
    private GameObject bomba_FX;

  
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bola"))
        {
           GameObject tempprefab = Instantiate(bomba_FX, new Vector2(this.transform.position.x, this.transform.position.y),Quaternion.identity) as GameObject;
            Audio_manager.instance.SonsFXToca(2);
            Destroy(this.gameObject);
            Destroy(tempprefab,1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
