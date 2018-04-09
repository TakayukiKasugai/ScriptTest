﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力
	private int mp = 53; //マジックポイント

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//魔法用の関数
	public void Magic(){
		if (mp - 5 >= 0) {//残りMPが足りているとき
			mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp + "。");
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}


	// Use this for initialization
	void Start () {
		//11回呼び出す
		for (int i = 0; i < 11; i++) {
			this.Magic ();
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
