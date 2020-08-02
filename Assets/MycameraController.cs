using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MycameraController : MonoBehaviour {
    //Unity ちゃんのオブジェクト
    private GameObject unitychan;

    //Unity ちゃんとカメラの距離
    private float difference;

	// Use this for initialization
	void Start () {
        
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unity ちゃんのカメラの位置(z座標)の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
	}
	
	// Update is called once per frame

	void Update () {
        //Unity ちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
	}
}
