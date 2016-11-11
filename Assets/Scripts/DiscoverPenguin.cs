using UnityEngine;
using System.Collections;

public class DiscoverPenguin : MonoBehaviour {

	/**
	 * Behaviour of a Person's line of sight to detect the penguin
	 * */

	public float sightDistance; //maximum distance at which to detect the penguin and end the game
	public float warningDistance; //maximum distance at which to display a "warning" symbol to indicate the penguin is getting too close

	public bool warning;
	public bool seen;

	void Start(){
		warning = false;
		seen = false;
	}

    void Update()
    {

		//if the penguin is already detected, we don't need any of this
		if (!seen) {
			PersonMovement pm = transform.parent.gameObject.GetComponent<PersonMovement> ();

			//otherwise, cast Ray to detect the penguin. The Layermask allows collision with other solid objects (platforms and boxes) in order to allow the penguin to hide behind them
			RaycastHit2D rh = Physics2D.Raycast (transform.position, pm.facingright ? transform.right : -transform.right, sightDistance, (1 << 8 | 1 << 9 | 1 << 10));
			//and cast a Ray to warn the penguin. 
			RaycastHit2D rhl = Physics2D.Raycast (transform.position, pm.facingright ? transform.right : -transform.right, warningDistance, (1 << 8));

			//if it hit the penguin, it loses
			if (rh && rh.collider.gameObject.layer == 8 && LevelManager.isPenguinDiscovered ()) 
			{
				pm.seePenguin ();
				seen = true;
				LevelManager.lose ();

			}
			//if it almost hit the penguin, set warning
			else if (rhl && rhl.collider.gameObject.layer == 8 && !warning && LevelManager.isPenguinDiscovered()) 
			{
				pm.suspectPenguin ();
				warning = true;
			} 

			//otherwise, remove a warning if one is active
			else if (warning && !rhl) 
			{
				pm.unsuspectPenguin ();
				warning = false;
			}
		}
    }
		
	void OnTriggerEnter2D(Collider2D c)
	{
		// If the penguin collapses with the person, it is discovered and the end of level is triggered
		if (c.gameObject.name == "Penguin")
		{
			if (LevelManager.isPenguinDiscovered()) {
				LevelManager.lose ();
			}
		}
	}
}
