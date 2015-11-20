using UnityEngine;
using System.Collections;

public class ButtleManager : MonoBehaviour {
	GameObject kaitoObj;
	GameObject tokageObj;
	Kaito kaito;
	Tokage tokage;
	public bool attackFlag;
	string kaitoName, tokageName;
	int checkWoL, loopCnt = 0;
	
	// Use this for initialization
	void Start () {
		kaitoObj = GameObject.Find("Shujinko");
		tokageObj = GameObject.Find("Enemy");
		tokage = tokageObj.GetComponent<Tokage>();
		kaito = kaitoObj.GetComponent<Kaito>();

		//UnityEngine.Debug.Log(tokage +" : "+ tokage.attack + " : " + tokage.defense + " : " + tokage.NAME);
	}
	
	// Update is called once per frame
	void Update () {
		if(loopCnt == 0){
			UnityEngine.Debug.Log(tokage.NAME + "が現れた! コマンド? ");
		}
		if(Input.GetKeyUp(KeyCode.Space)){
			myTurn();
			checkWoL = checkWinOrLoss();
			enemyTurn();
			checkWoL = checkWinOrLoss();

		}
		loopCnt = 1;
	}

	/*
	myTurn:自分のターンに行う処理。
	*/
	public void myTurn(){
		doAttack(kaito, tokage);

	}

	/*
	enemyTurn:相手のターンに行う処理。
	*/
	public void enemyTurn(){
		int act = (int)(Random.value * 10);
		if(act < 9){
			doAttack(tokage, kaito);
		}
		else {
			//useCrown();
			UnityEngine.Debug.Log(tokage.NAME + "は王冠を使おうとした！");
			UnityEngine.Debug.Log("しかしMPが足りなかった！");
		}
	}

	/*
	doAttack:攻撃のメソッド。
	attack_man:攻撃側
	damage_man:攻撃される側
	*/
	public void doAttack(AbstractButtleParameter attack_man, AbstractButtleParameter damage_man){
		attackFlag = true;//アニメーション用フラグ
		int magnification = computeMag(attack_man, damage_man);
		double randnum = Random.Range(0.8f, 1.0f);
		int damage = (int)((attack_man.attack - damage_man.defense) * magnification * randnum);
		
		//UnityEngine.Debug.Log("(" + attack_man.attack + "-" + damage_man.defense + ") * "+ magnification + " * " + randnum);
		
		damage_man.hp -= damage;
		UnityEngine.Debug.Log (attack_man.NAME + "の攻撃！");
		UnityEngine.Debug.Log(damage_man.NAME + "は" + damage + "のダメージを受けた!");
		UnityEngine.Debug.Log(damage_man.NAME + "の残りHP:" + damage_man.hp);

	}

	/*
	defend:防御のメソッド
	*/
	public void defend(){}

	/*
	useCrown:王冠(魔法的なやーつ)を使うメソッド
	*/
	public void useCrown(){}

	/*
	escape:逃げるコマンドのメソッド
	*/
	public void escape(){}


	/*
	computeMag:相性の倍率計算をする。
	
	attack_man:攻撃側
	damage_man:攻撃される側
	*/
	public int computeMag(AbstractButtleParameter attack_man, AbstractButtleParameter damage_man){
		int magnification = 1;

		//if (attack_man.color[0] == 0 || damage_man.color[0] == 0) {
		//	return magnification;
		//}
		for(int i = 0; i < 2; i++){
			for(int k = 0; k < 2; k++){
				if(damage_man.color[i] - attack_man.color[k] == 1 || (damage_man.color[i] == 3 && attack_man.color[k] == 1 )){
					magnification *= 2;
				}
				if(magnification <= 4)break;//倍率4倍まで制限
			}
		}
		return magnification;
	}

	/*
	checkWinOrLoss:勝敗判定をするメソッド
	勝敗判定によってお金なくすとかの処理をしたり、王冠貰う処理に以降する。
	又は全てこのメソッドで行い、フィールド画面に遷移する処理までする
	*/
	public int checkWinOrLoss(){
		int result = 0;//0は勝敗が決まっていない状態
		if(kaito.hp <= 0){
			UnityEngine.Debug.Log(kaito.NAME + "はやられてしまった！");
			result = 2;//2は負け
		}

		if(tokage.hp <= 0){
			UnityEngine.Debug.Log(tokage.NAME + "を倒した！");
			result = 1;//1は勝ち
		}

		return result;
	}

	/*
	selectEnemy:攻撃の対象にする敵を選ぶメソッド。
	相手が一人の時は実行しなくていい（と思う）
	敵が攻撃するときはランダムに攻撃するようにする(enemyTurnで実装するかも)
	*/
	//public AbstractButtleParameter selectEnemy(){}



}
