using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCurve1 : MonoBehaviour
{
    public float Timer;
    public Rigidbody2D rig;
    private float _shotTimer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
        GetComponent<Rigidbody2D>();
        rig.AddForce(Vector3.up * 6f, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        transform.Translate(((0.5f - Timer) - 0.05f), 0, 0f);
        if (Timer < 1) 
        {
            Timer += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
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
