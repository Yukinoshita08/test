using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStraight : MonoBehaviour
{
    private float _shotTimer;
    public float m_shotInterval; // 弾の発射間隔（秒）

    void Start()
    {
        Rigidbody2D bltRigid;
        bltRigid = GetComponent<Rigidbody2D>();
        //射出速度
        bltRigid.AddForce(Vector2.up * 10f, ForceMode2D.Impulse);
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

        if (_shotTimer < m_shotInterval) return;

    }
}