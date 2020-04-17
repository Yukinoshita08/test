using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    public float hp = 100;  //体力
    private float timeOut = 4.0f;
    private float countup = 0.0f;
    private float TimeCount = 7.5f;
    bool isCalled = false;
    public float heal = 10;
    public delegate void RespawnDelegate();

    void Update()
    {
        countup += Time.deltaTime;

        //2秒ごとに回復する
        if (hp > 0 && hp < 100 && isCalled == true)
        {
            countup += Time.deltaTime;

            if (countup >= timeOut)
            {
                hp += heal;
                Debug.Log("heal HP" + hp + "/100");
                countup = 0.0f;
            }
        }

        //【5秒後に回復するプログラム】
        else if (countup >= TimeCount && isCalled == false)
        {
            countup += Time.deltaTime;

            if (hp > 0 && hp < 100)
            {
                hp += heal;
                isCalled = true;
                countup = 0.0f;
                Debug.Log("Heal HP" + hp + "/100");
            }
        }


    }
    //貫通する場合はTrigger系(どちらかにColliderのis triggerをチェック) 衝突しあうものはCollision系(ColliderとRigidbodyが必要)
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("a"+collision.gameObject.name);

        //タグがEnemyのオブジェクトが当たった時に{}内の処理が行われる
        if (collision.gameObject.tag == "Enemy")
        {
            //gameObject.GetComponent<EnemyBulletManager>()でEnemyBulletManagerスクリプトを参照し
            //.powerEnemy; でEnemyBulletManagerのpowerEnemyの値をゲット
            hp -= collision.gameObject.GetComponent<EnemyDamage>().powerEnemy;
            if (hp > 0)
            {
                Debug.Log("P_HP" + hp + "/100");  //コンソールにhit Playerが表示
                isCalled = false;
            }
        }

        //体力が0以下になった時{}内の処理が行われる
        if (hp <= 0)
        {
            Debug.Log("GAME OVER");
        }
    }
}