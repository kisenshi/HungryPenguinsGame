using UnityEngine;
using System.Collections;

public class CollectFish : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D c)
    {

        if (c.gameObject.name == "Penguin")
        {
			Destroy (this.gameObject);
			LevelManager.collectFish ();
        }
    }
}
