using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{

    public GameObject[] weapons;
    public AudioClip changeSound;
    public int currentNum = 0;

    void Start()
    {
        // ★繰り返し文の復習
        for (int i = 0; i < weapons.Length; i++)
        {
            // ★条件文の復習
            if (i == currentNum)
            {
                weapons[i].SetActive(true);
            }
            else
            {
                weapons[i].SetActive(false);
            }
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {


            // ★重要テクニック
            // 配列の中の順序を１つずつ繰り上げていくテクニック（最後はまた０に戻るのがポイント）
            // 紙に書いて、currentNumの中の数字がどのように変化するか確認してみましょう！
            currentNum = (currentNum + 1) % weapons.Length;

            for (int i = 0; i < weapons.Length; i++)
            {
                if (i == currentNum)
                {
                    weapons[i].SetActive(true);
                }
                else
                {
                    weapons[i].SetActive(false);
                }
            }
        }
    }
}
