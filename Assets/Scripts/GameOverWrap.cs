using UnityEngine;
using System.Collections;

public class GameOverWrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelManager.onDeath += activateAll;
	}

	private void activateAll(){
		foreach (Transform child in transform) {
			child.gameObject.SetActive (true);
		}
	}

	void OnDestroy(){
		LevelManager.onDeath -= activateAll;
	}
}
