using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carro : MonoBehaviour
{
    public GameObject exp;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        switch (collision.gameObject.tag)
        {
           
            case "Player":
                Destroy(gameObject);
                GameObject temprefab = Instantiate(exp) as GameObject;
                temprefab.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                SoundManager.PlaySom("Explosion");
                break;
            case "DrinkBlue":
                Destroy(gameObject);
                break;
            case "DinkRed":
                Destroy(gameObject);
                break;

            case "CArro":
                Destroy(gameObject);
                break;
            case "barreira":
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
}
