using UnityEngine;
using System.Collections;

public class Sendshake : MonoBehaviour {
	/*
	カイトからカメラにカイトの攻撃アニメーションが終わったことを伝えるクラス
	*/
	Animator cameraAnimator;
	int cameraId;

	void Start () {
		cameraAnimator = GameObject.Find("Main Camera").GetComponent<Animator>();

	}
	
	void Update () {}

	void shake(){
		cameraAnimator.SetTrigger("shake");
		UnityEngine.Debug.Log ("shake");
	}
}
