using UnityEngine;
using System.Collections;

public class DiscoverPenguin : MonoBehaviour {

	public float sightDistance;
	public float warningDistance;

	public bool warning;
	public bool seen;

	void Start(){
		warning = false;
		seen = false;
	}

    void Update()
    {

		if (!seen) {
			PersonMovement pm = transform.parent.gameObject.GetComponent<PersonMovement> ();

			RaycastHit2D rh = Physics2D.Raycast (transform.position, pm.facingright ? transform.right : -transform.right, sightDistance, (1 << 8 | 1 << 9 | 1 << 10));
			RaycastHit2D rhl = Physics2D.Raycast (transform.position, pm.facingright ? transform.right : -transform.right, warningDistance, (1 << 8));

			if (rh && rh.collider.gameObject.layer == 8 && LevelManager.isPenguinDiscovered ()) 
			{
				pm.seePenguin ();
				seen = true;
				LevelManager.lose ();

			}
			else if (rhl && rhl.collider.gameObject.layer == 8 && !warning && LevelManager.isPenguinDiscovered()) 
			{
				pm.suspectPenguin ();
				warning = true;
			} 
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
