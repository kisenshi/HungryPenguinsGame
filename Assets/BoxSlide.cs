using UnityEngine;
using System.Collections;

public class BoxSlide : MonoBehaviour {

	public float slidespeed;
	public float slideaccel;

	private bool stop;

//	private bool sliding;
//	private int i=0;


	void LateUpdate(){
		
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();
		float y = vel.velocity.y;
		float x = vel.velocity.x;


		/**if (sliding&&x==0) {
			i++;
			sliding = i > 10 ? false : sliding;
			i = i > 10 ? 0 : i;
		}*/

		if (stop) {
			vel.velocity = new Vector2 (0, 0);
		}

		else if (x != 0 && x < slidespeed) {
			vel.AddForce (x > 0 ? transform.right * slideaccel : -transform.right * slideaccel, ForceMode2D.Force);
		}


	}

	void OnCollisionEnter2D(Collision2D c){

		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();

		if ((c.gameObject.name == "WoodBox" || c.gameObject.name == "IceBox")) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel.velocity.y);
			c.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, c.gameObject.GetComponent<Rigidbody2D> ().velocity.y);
			stop = true;
		}
	}
}
