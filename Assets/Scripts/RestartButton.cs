using UnityEngine;
using System.Collections;

public class RestartButton : MonoBehaviour {

	public void restart(){
		LevelManager.closeMenus ();
		LevelManager.restartLevel ();

	}
		
}
