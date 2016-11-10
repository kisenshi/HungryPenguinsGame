using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	public void restart(){
		LevelManager.closeMenus ();
		LevelManager.restartLevel ();
	}

	public void Update(){

		if (Input.GetKeyDown (KeyCode.R)) {
			// Player will be able to restart pressing R too
			restart ();
		}

		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Z)){
			// Player is able to skip the info or game over screen pressing Space
			if (gameObject.name == "GameOverRestart") {
				restart ();
			}
		}	
		
	}
}
