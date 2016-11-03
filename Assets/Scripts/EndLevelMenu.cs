using UnityEngine;
using System.Collections;

public class EndLevelMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelManager.onFinish += activateAll;
	}
	
	private void activateAll(){
		foreach (Transform child in transform) {
			child.gameObject.SetActive (true);
		}
	}

	void OnDestroy(){
		LevelManager.onFinish -= activateAll;
	}
}
