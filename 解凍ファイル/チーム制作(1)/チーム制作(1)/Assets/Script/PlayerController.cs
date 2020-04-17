using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject Straight;
    public Transform target;
    public GameObject ReturnPrefab;

    

    private float _shotTimer;

     void Start()
    {
        
    }
    //毎フレーム呼び出されるメソッド
    void Update()
    {


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.1f, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.1f, 0);
        }

        //if (Input.GetKeyDown(KeyCode.Q) && _shotTimer <= 0f) 
        //{
        //    _shotTimer = 0.5f;

        //    Instantiate(ReturnPrefab, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
        //}



        //else if (Input.GetKeyDown(KeyCode.E) && _shotTimer <= 0f)
        //{
        //    _shotTimer = 0.5f;

        //    Instantiate(bulletPrefab, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        //}

        if (Input.GetKeyDown(KeyCode.Q) && _shotTimer <= 0f)
        {
            _shotTimer = 1.0f;

        }

        if (_shotTimer > 0)
        {
            _shotTimer -= Time.deltaTime;
        }



    }

}

