using UnityEngine;
using System.Collections;

public abstract class PersistentUIInterface : MonoBehaviour {





	//DO NOT IMPLEMENT IN CHILDREN
	//OR ELSE
	void Start(){
		DontDestroyOnLoad (this.gameObject);
		myStart ();
	}

	//USE THIS INSTEAD
	protected abstract void myStart();

	//ALSO THIS
	 void OnLevelWasLoaded(){
		reset ();
		myOnLevelWasLoaded ();
	}

	protected abstract void myOnLevelWasLoaded ();

	protected abstract void reset();



}
