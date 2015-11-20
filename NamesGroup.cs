using UnityEngine;
using System.Collections;

public class NamesGroup : MonoBehaviour {

	// Use this for initialization
	public GameObject enemy, shujinko;

	void Start () {
		enemy = GameObject.Find ("Enemy");
		shujinko = GameObject.Find ("Shujinko");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
