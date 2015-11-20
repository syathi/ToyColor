using UnityEngine;
using System.Collections;

public class sendDamage : MonoBehaviour {

	Animator enemyAnimator;
	NamesGroup group;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void damage(){
		group = GameObject.Find("God").GetComponent<NamesGroup>();
		enemyAnimator = group.enemy.GetComponent<Animator> ();
		enemyAnimator.SetTrigger ("damaged");
		UnityEngine.Debug.Log ("damage");
	}
}
