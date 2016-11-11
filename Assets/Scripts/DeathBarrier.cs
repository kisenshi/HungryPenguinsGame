using UnityEngine;
using System.Collections;

public class DeathBarrier : MonoBehaviour {

	/**
	 * Behavior to end the game if the penguin falls off the screen
	 * */

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.name == "Penguin")
		{
			GetComponent<AudioSource> ().Play ();
			c.gameObject.SetActive(false);
			LevelManager.lose ();
		}
	}

    
}
