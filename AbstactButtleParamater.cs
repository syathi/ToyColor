using UnityEngine;
using System.Collections;

public class AbstractButtleParameter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//paramaters
	public string NAME;
	public int MAX_ATK;
	public int attack;
	public int MAX_DEF;
	public int defense;
	public int MAX_MAGIC_ATK;
	public int magic_atk;
	public int MAX_HP;
	public int hp;
	public int MAX_MP;
	public int mp;
	public int[] color = new int[2]; //0,1,2,3
	 //color[0] = 0;
	//color[1] = 1;
	//public int color2; //0,1,2,3
	protected bool[] crown = new bool[28];//王冠28種類。それぞれの値から内容を取り出して実装

	//buttle commands
	/*
	 attack_man:自分。攻撃力とかを参照する
	 damage_man:相手。防御力とかHPとかを参照する
	*/
	protected void doAttack(AbstractButtleParameter attack_man, AbstractButtleParameter damage_man){}
	
	protected void doDefense(AbstractButtleParameter attack_man, AbstractButtleParameter damage_man){}
	
	protected void useCrown(){}
	protected void escape(){}


}
