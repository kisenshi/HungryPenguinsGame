using UnityEngine;
using System.Collections;

public class CollectFish : MonoBehaviour {

	/**
	 * Controls collection of fish pickups
	 * */

    void OnTriggerEnter2D(Collider2D c)
    {

        if (c.gameObject.name == "Penguin")
        {
			Destroy (this.gameObject);
			LevelManager.collectFish ();

        }
    }
}
