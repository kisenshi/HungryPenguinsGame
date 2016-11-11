using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	/**
	 * Detects if the penguin touches it with all fish found to end the level
	 * */


	void OnTriggerEnter2D(Collider2D c){
		if (LevelManager.isLevelCompleted() && c.gameObject.name == "Penguin") {
			LevelManager.win ();
		}
	}


}
