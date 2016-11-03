using UnityEngine;
using System.Collections;

public class DeathBarrier : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.name == "Penguin")
		{
			c.gameObject.SetActive(false);
			LevelManager.lose ();
		}
	}

    
}
