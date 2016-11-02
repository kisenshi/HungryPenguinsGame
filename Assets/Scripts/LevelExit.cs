using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	public GameObject levelManager;
	private LevelManager lm;

	void Start(){
		lm = levelManager.GetComponent<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D c){
		if (lm.isLevelCompleted() && c.gameObject.name == "Penguin") {
			Debug.Log ("Works!");
		}
	}
}
