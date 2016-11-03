using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D c){
		if (LevelManager.isLevelCompleted() && c.gameObject.name == "Penguin") {
			LevelManager.win ();
		}
	}


}
