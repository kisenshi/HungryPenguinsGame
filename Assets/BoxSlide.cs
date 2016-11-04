using UnityEngine;
using System.Collections;

public class BoxSlide : MonoBehaviour {

	public float slidespeed;
	public float slideaccel;

	private bool stop;





	void LateUpdate(){
		
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();
		float y = vel.velocity.y;
		float x = vel.velocity.x;




		if (!stop && x != 0 && x < slidespeed) {
			vel.AddForce (x > 0 ? transform.right * slideaccel : -transform.right * slideaccel, ForceMode2D.Force);
		}


	}

	void OnCollisionEnter2D(Collision2D c){

		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();

		if ((c.gameObject.name == "WoodBox" || c.gameObject.name == "IceBox")) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel.velocity.y);
			c.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, c.gameObject.GetComponent<Rigidbody2D> ().velocity.y);

			Vector2 dir = c.contacts [0].point - (Vector2)transform.position;
			dir = -dir.normalized;

			transform.position = new Vector2 (transform.position.x + dir.x * 0.01f, transform.position.y);

		}
	}
}
