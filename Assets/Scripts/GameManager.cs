using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
//deprec
public static class GameManager {

	public static void restartLevel(){
		LevelManager.restartLevel ();
//		int scene = SceneManager.GetActiveScene().buildIndex;
//		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}

	public static void LoadNextLevel(){
		LevelManager.LoadNextLevel ();
//		Application.LoadLevel ("Level2");
//		string nextLevelTag = GameObject.Find("Level").GetComponent<LevelManager>().nextLevelTag;
//		SceneManager.LoadScene(nextLevelTag, LoadSceneMode.Single);
	}

}
