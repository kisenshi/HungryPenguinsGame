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
		if (Input.GetKeyDown(KeyCode.R))
		{
			// Player will be able to restart pressing R too
			LevelManager.closeMenus ();
			LevelManager.restartLevel ();
		}
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
