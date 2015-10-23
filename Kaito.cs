using UnityEngine;
using System.Collections;

public class Kaito :AbstractButtleParameter{

	GameObject manager;
	ButtleManager buttleManager;
	// Use this for initialization
	void Start () {
		manager = GameObject.Find("Wall");
		buttleManager = manager.GetComponent<ButtleManager>();

		setParam();
		setAnimator();


	}
	
	// Update is called once per frame
	void Update () {
		if(buttleManager.attackFlag){
			animator.SetBool(attackAnimeId, true);
			buttleManager.attackFlag = false;
		}
	}

	void setParam(){
		NAME = "カイト";
		MAX_ATK = 110;
		attack = MAX_ATK;
		MAX_DEF = 100;
		defense = MAX_DEF;
		MAX_MAGIC_ATK = 115;
		magic_atk = MAX_MAGIC_ATK;
		MAX_HP = 300;
		hp = MAX_HP;
		MAX_MP = 150;
		mp = MAX_MP;
		color = new int[2];
		color[0] = 0; //とりあえず無色
		color[1] = 0;
		UnityEngine.Debug.Log(NAME + ": attack:"+attack +" defense:" + defense + " magic_atk:" + magic_atk + " hp:"+ hp + " mp:" + mp + " color:" + color[0] + color[1]);

	}

	void setAnimator(){
		animator = GetComponent<Animator> ();
		attackAnimeId = Animator.StringToHash("attackAnime");
	}

}