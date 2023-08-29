using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestruction : MonoBehaviour
{
    //GameObject型の変数camを宣言
    private GameObject cam;

    //float型（浮動小数点数値型）の変数differenceを宣言
    private float difference;

    void Start()
    {

    }

    void Update()
    {
        //変数camにカメラゲームオブジェクトを探して代入
        this.cam = GameObject.Find ("Main Camera");

        //カメラと、このスクリプトがアタッチされたオブジェクトのZ座標の距離を求める
        this.difference = cam.transform.position.z - this.transform.position.z;

        //距離が0より大きい値ならば画面外なのでアイテムを破棄する
        if (difference > 0) 
        {
            Destroy(gameObject);
        }
    }
}