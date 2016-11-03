using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class GameManager {

	public static void restartLevel(){

		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
}

}
