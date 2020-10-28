using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInimigo : MonoBehaviour
{
    public GameObject carroceria;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -70 * Time.deltaTime, 0);
        if (transform.position.z < -2268)
        {
            Destroy(gameObject);
            Destroy(carroceria);
        }
    }
}
