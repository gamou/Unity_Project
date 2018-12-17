using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //スワイプの長さを求める
        if(Input.GetMouseButtonDown(0))
        {
            //マウスをクリックした座標
            this.startPos = Input.mousePosition;
        }else if(Input.GetMouseButtonUp(0))
        {
            //マウスを離した座標
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - this.startPos.x;

            //スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;
        }

        /*
        //------------------マウスクリックでの処理------------------//

        if(Input.GetMouseButtonDown(0))          //マウスが押されたら
        {
            this.speed = 0.2f;                   //初速度を設定
        }
        
        //---------------------------------------------------------//
        */

        transform.Translate(this.speed, 0, 0);  //移動
        this.speed *= 0.98f;                    //減速
    }
}
