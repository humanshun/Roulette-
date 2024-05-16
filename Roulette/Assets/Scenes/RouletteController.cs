using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        //フレームレートを６０に固定する
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed += 10;
        }
        //回転速度ぶん、ルーレットを回転させる。
        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減速させる（追加）
        this.rotSpeed *= 0.99f;

        if(this.rotSpeed <= 0.1)
        {
            this.rotSpeed = 0;
        }
    }
}
