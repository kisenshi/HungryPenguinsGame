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


		if (LevelManager.isFinal ()) {
			Destroy (gameObject);
		}
	}
}
