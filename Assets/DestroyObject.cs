using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    //Unity ちゃんのオブジェクト
    private GameObject unitychan;

    //Unity ちゃんとカメラの距離
    private float difference=10.0f;

    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }

    // Update is called once per frame

    void Update(){

        if (transform.position.z < (this.unitychan.transform.position.z - difference)){

            Destroy(gameObject);
        }
    }
}
