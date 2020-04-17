using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour
{
    public GameObject Straight, Curve, Curve2, Return;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(Straight, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(Curve, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(Curve2, transform.position, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(Return, transform.position, Quaternion.identity);
        }
    }
}
