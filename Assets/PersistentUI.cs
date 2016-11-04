using UnityEngine;
using System.Collections;

public class PersistentUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnLevelWasLoaded(){

		Debug.Log ("Loaded");

		if (LevelManager.isFinal ()) {
			Debug.Log ("Go away now");
			Destroy (gameObject);
		}
	}
}
