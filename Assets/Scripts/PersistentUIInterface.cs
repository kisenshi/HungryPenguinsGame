using UnityEngine;
using System.Collections;

public abstract class PersistentUIInterface : MonoBehaviour {


	sealed void  Start(){
		DontDestroyOnLoad (this.gameObject);
		myStart ();
	}

	void myStart();

	sealed void OnLevelWasLoaded(){
		reset ();
		myOnLevelWasLoaded ();
	}

	void myOnLevelWasLoaded ();

	void reset();



}
