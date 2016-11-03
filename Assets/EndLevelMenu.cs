using UnityEngine;
using System.Collections;

public class EndLevelMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelExit.onFinish += activateAll;
	}
	
	private void activateAll(){
		foreach (Transform child in transform) {
			child.gameObject.SetActive (true);
		}
	}

	void OnDestroy(){
		LevelExit.onFinish -= activateAll;
	}
}
