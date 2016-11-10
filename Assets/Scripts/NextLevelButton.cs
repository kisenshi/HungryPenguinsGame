using UnityEngine;
using System.Collections;

public class NextLevelButton : MonoBehaviour {

	public void loadNextLevel(){
		LevelManager.closeMenus ();
		GameManager.LoadNextLevel ();
	}

	public void Update(){
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Z))
		{
			loadNextLevel ();
		}
	}
}
