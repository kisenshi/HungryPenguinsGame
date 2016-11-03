using UnityEngine;
using System.Collections;

public class DeathBarrier : MonoBehaviour {

	public delegate void death();
	public static event death onDeath;

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.name == "Penguin")
		{
//			GameManager.restartLevel();
			onDeath();
		}
	}

    
}
