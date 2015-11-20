using UnityEngine;
using System.Collections;

public class AttackButton : MonoBehaviour {

	Animator shujinkoAnimator;
	NamesGroup group;
	int attackAnimeId;
	ButtleManager buttleManager;
	int checkWorL;
	void Start () {
		UnityEngine.Debug.Log ("start");
		buttleManager = GameObject.Find("ButtleManager").GetComponent<ButtleManager>();
		group = GameObject.Find("God").GetComponent<NamesGroup>();
		//shujinkoAnimator = group.shujinko.GetComponent<Animator> ();
		attackAnimeId = Animator.StringToHash("attackAnime");

	}
	
	// Update is called once per frame
	//void Update () {

	//}

	public void OnClick(){
		shujinkoAnimator = group.shujinko.GetComponent<Animator> ();

		buttleManager.myTurn();
		checkWorL = buttleManager.checkWinOrLoss();
		buttleManager.enemyTurn();
		checkWorL = buttleManager.checkWinOrLoss();
		if(buttleManager.attackFlag){//Buttlemanagerから攻撃フラグ取得sるう
			shujinkoAnimator.SetBool(attackAnimeId, true);
			buttleManager.attackFlag = false;
		}

	}
}
