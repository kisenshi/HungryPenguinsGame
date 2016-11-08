using UnityEngine;
using System.Collections;

public class PersistentUI : MonoBehaviour {

	private static bool uiLoaded = false;

	// Use this for initialization
	void Start () {
		if (uiLoaded) {
			Destroy (this.gameObject);
		} 
		else {
			DontDestroyOnLoad (this.gameObject);
			uiLoaded = true;
		}
	}

	// Update is called once per frame
	void Update () {

	}
		
	void OnLevelWasLoaded(){


		if (LevelManager.isFinal ()) {
			uiLoaded = false;
			Destroy (gameObject);
		}
	}

	void OnDestroy(){

	}
}
