using UnityEngine;
using System.Collections;

public class EndLevelMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		LevelManager.onFinish += activateAll;
		LevelManager.resume += deactivateAll;
	}

	private void activateAll(){
		foreach (Transform child in transform) {
			if(child!=gameObject) child.gameObject.SetActive (true);
			GetComponent<AudioSource> ().Play ();
		}
	}

	private void deactivateAll(){
		foreach (Transform child in transform) {
			if(child!=gameObject) child.gameObject.SetActive (false);
		}
	}



	void OnDestroy(){
		LevelManager.resume -= deactivateAll;
		LevelManager.onFinish -= activateAll;
	}
}
