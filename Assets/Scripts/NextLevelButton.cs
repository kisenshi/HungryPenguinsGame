using UnityEngine;
using System.Collections;

public class NextLevelButton : MonoBehaviour {



	public void loadNextLevel(){
		LevelManager.closeMenus ();
		GameManager.LoadNextLevel ();
	}
}
