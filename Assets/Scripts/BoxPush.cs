using UnityEngine;
using System.Collections;

public class BoxPush : MonoBehaviour {

	private bool pushing;
	private int pushtimer;

	void Start(){
		pushing = false;
		pushtimer = 0;
	}

	void OnCollisionEnter2D(Collision2D c){

	}
}
