using UnityEngine;
using System.Collections;

public class LevelExit : MonoBehaviour {

	public GameObject levelManager;
	private LevelManager lm;

	public delegate void finish();
	public static event finish onFinish;

	void Start(){
		lm = levelManager.GetComponent<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D c){
		if (lm.isLevelCompleted() && c.gameObject.name == "Penguin") {
			onFinish ();
//			GameObject.Find("EndLevelMsg"
			//GameManager.LoadNextLevel ();
		}
	}


}
