using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (true)
		{
			Camera cam = gameObject.GetComponent<Camera> ();

			// 理想の画面の比率
			float targetRatio = 9f / 16f;	
			// 現在の画面の比率
			float currentRatio = Screen.width * 1f / Screen.height;
			// 理想と現在の比率
			float ratio = targetRatio / currentRatio;

			//カメラの描画開始位置をX座標にどのくらいずらすか
			float rectX = (1.0f - ratio) / 2f;
			//カメラの描画開始位置と表示領域の設定
			cam.rect = new Rect (rectX, 0f, ratio, 1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Awake()
	{

	}

}
