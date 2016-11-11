using UnityEngine;
using System.Collections;

/**
 * Controls the behaviour of sliding ice blocks.
 * */
public class BoxSlide : MonoBehaviour {

    public float slidespeed;
    public float slideaccel;
    public int framestomove;







    void LateUpdate() {

        Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();
        float y = vel.velocity.y;
        float x = vel.velocity.x;




		//If it's already moving and isn't at max speed...
        if (x != 0 && x < slidespeed) {
			//increase the speed
            vel.AddForce(x > 0 ? transform.right * slideaccel : -transform.right * slideaccel, ForceMode2D.Force);
        }

		fixSpeed ();
    }


	//ensures that max speed is clamped
	void fixSpeed(){
		Rigidbody2D r = gameObject.GetComponent<Rigidbody2D>();
		float y = r.velocity.y;
		float x = r.velocity.x;

		r.velocity = x > slidespeed ? new Vector2(slidespeed, y) : x < -slidespeed ? new Vector2(-slidespeed, y) : r.velocity;
	}


	/**void OnCollisionEnter2D(Collision2D c){

		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();



		if (c.gameObject.layer == 9) {
			gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vel.velocity.y);
			c.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, c.gameObject.GetComponent<Rigidbody2D> ().velocity.y);

			Vector2 dir = c.contacts [0].point - (Vector2)transform.position;
			dir = -dir.normalized;

			transform.position = new Vector2 (transform.position.x + dir.x * 0.01f, transform.position.y);

		}
	}*/
}
