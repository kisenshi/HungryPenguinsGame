using UnityEngine;
using System.Collections;

public class BoxSlide : MonoBehaviour {

	public float slidespeed;
	public float slideaccel;

	private int slidedir;

	void LateUpdate(){
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();
		float y = vel.velocity.y;
		float x = vel.velocity.x;

		if (x != 0 && x < slidespeed) {
			vel.AddForce (x > 0 ? transform.right * slideaccel : -transform.right * slideaccel, ForceMode2D.Force);
			//slidedir = x > 0 ? 1 : 0;
		}
	}

	void OnCollisionEnter2D(Collision2D c){
		if (c.gameObject.name == "WoodBox")
			Debug.Log ("crash");
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
	}
}
