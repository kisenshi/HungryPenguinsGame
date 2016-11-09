using UnityEngine;
using System.Collections;

public class PersistentUI : MonoBehaviour {

	private static bool uiLoaded = false;
	private bool realUI;

	// Use this for initialization
	void Start () {
		realUI = false;
		if (uiLoaded) {
			Destroy (this.gameObject);
		} 
		else {
			DontDestroyOnLoad (this.gameObject);
			uiLoaded = true;
			realUI = true;
		}
	}

	// Update is called once per frame
	void Update () {

	}
		
	void OnLevelWasLoaded(){


		if (LevelManager.isFinal ()) {
			Destroy (gameObject);
		}
	}

	void OnDestroy(){
		if (realUI) {
			uiLoaded = false;
		}
	}
}
