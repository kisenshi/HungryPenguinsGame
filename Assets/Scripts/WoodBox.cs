using UnityEngine;
using System.Collections;

public class WoodBox : MonoBehaviour {



	public void Freeze(){

			gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;

	}

	public void unFreeze(){
		gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
	}



	}


