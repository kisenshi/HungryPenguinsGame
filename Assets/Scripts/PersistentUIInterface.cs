using UnityEngine;
using System.Collections;

public abstract class PersistentUIInterface : MonoBehaviour {





	//DO NOT IMPLEMENT IN CHILDREN
	void Start(){
		DontDestroyOnLoad (this.gameObject);
		Debug.Log ("superclass call");
		myStart ();
	}

	protected abstract void myStart();

	 void OnLevelWasLoaded(){
		reset ();
		myOnLevelWasLoaded ();
	}

	protected abstract void myOnLevelWasLoaded ();

	protected abstract void reset();



}
