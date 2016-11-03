using UnityEngine;
using System.Collections;

public class GameOverWrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DeathBarrier.onDeath += activateAll;
	}

	private void activateAll(){
		foreach (Transform child in transform) {
			child.gameObject.SetActive (true);
		}
	}

	void OnDestroy(){
		DeathBarrier.onDeath -= activateAll;
	}
}
