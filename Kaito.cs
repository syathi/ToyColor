using UnityEngine;
using System.Collections;

public class Kaito :AbstractButtleParameter{

	// Use this for initialization
	void Start () {
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
		color1 = 0; //とりあえず無色
		color2 = 0;
		UnityEngine.Debug.Log("attack:"+attack +" defense:" + defense + " magic_atk:" + magic_atk + " hp:"+ hp + " mp:" + mp + " color:" + color1);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}