using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bulletPrefab;
    public float shotSpeed;

    private float shotInterval;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            shotInterval += 1;

            if (shotInterval % 1 == 0)
            {


                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから0.5秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 0.5f);
            }

        }


    }
}
