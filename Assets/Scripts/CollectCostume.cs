using UnityEngine;
using System.Collections;

public class CollectCostume : MonoBehaviour {

	/**
	 * Controls collection of costume pickups
	 * */

	public string type;

	void Awake(){
		//		Debug.Log (type);
		//		Sprite penguinCostume = (Sprite) Resources.Load(type, typeof(Sprite));
		//		Debug.Log (penguinCostume);
		//this.GetComponent<SpriteRenderer>().sprite = penguinCostume;
		//		Debug.Log (this.GetComponent<SpriteRenderer>());
	}

	void OnTriggerEnter2D(Collider2D c)
	{

		if (c.gameObject.name == "Penguin")
		{
			Destroy (this.gameObject);
			LevelManager.collectCostume (type);
		}
	}
}
