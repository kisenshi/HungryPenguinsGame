using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour {

	private void restartCurrentLevel()
	{
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}


	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.name == "Penguin")
		{
			restartCurrentLevel();
		}
	}

    
}
