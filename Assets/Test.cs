using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {



	// Use this for initialization
	void Start () {
		//配列の初期化
		int[] array = { 111, 135, 333, 555, 777 };

		//配列の内容を順番にコンソールに表示
		for (int i = 0; i < array.Length; i++){
			Debug.Log (array [i]);
		}

		//配列の内容を逆順にコンソールに表示
		for (int i = array.Length -1; i >= 0; i--){
			Debug.Log (array [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
