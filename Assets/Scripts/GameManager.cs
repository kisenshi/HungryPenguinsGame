using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class GameManager {

	public static void restartLevel(){
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}

	public static void LoadNextLevel(){
//		Application.LoadLevel ("Level2");
		string nextLevelTag = GameObject.Find("Level").GetComponent<LevelManager>().nextLevelTag;
		SceneManager.LoadScene(nextLevelTag, LoadSceneMode.Single);
	}

}
