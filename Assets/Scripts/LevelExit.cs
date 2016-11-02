using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	public GameObject display;
	private FishDisplay fd;

	void Start(){
	
		fd = display.GetComponent<FishDisplay> ();
	
	}

	private bool levelComplete(){
		return fd.collected >= fd.fishes;
	}

	void OnTriggerEnter2D(Collider2D c){
		if (levelComplete() && c.gameObject.name == "Penguin") {
			Debug.Log ("Works!");
		}
	}
}
