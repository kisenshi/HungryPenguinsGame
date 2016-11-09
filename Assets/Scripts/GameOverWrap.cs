using UnityEngine;
using System.Collections;

public class GameOverWrap : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelManager.onDeath += activateAll;
		LevelManager.resume += deactivateAll;
	}

	private void activateAll(){
		foreach (Transform child in transform) {
			if(child!=gameObject) child.gameObject.SetActive (true);

		}
	}

	private void deactivateAll(){
		foreach (Transform child in transform) {
			if(child!=gameObject) child.gameObject.SetActive (false);
		}
	}
		
	void OnDestroy(){
		LevelManager.resume -= deactivateAll;
		LevelManager.onDeath -= activateAll;
	}
}
