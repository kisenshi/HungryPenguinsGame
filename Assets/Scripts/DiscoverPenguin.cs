using UnityEngine;
using System.Collections;

public class DiscoverPenguin : MonoBehaviour {

	public float sightDistance;
	public float warningDistance;

	public bool warning;

	void Start(){
		warning = false;
	}

    void Update()
    {

		PersonMovement pm = transform.parent.gameObject.GetComponent<PersonMovement> ();
        RaycastHit2D rh = Physics2D.Raycast(transform.position, pm.facingright ? transform.right : -transform.right, sightDistance, (1 << 8 | 1 << 9 | 1 << 10));
        if (rh && rh.collider.gameObject.layer == 8)
        {
            if (LevelManager.isPenguinDiscovered())
            {
                LevelManager.lose();

            }
        }

		RaycastHit2D rhl = Physics2D.Raycast(transform.position, pm.facingright ? transform.right : -transform.right, warningDistance, (1 << 8));
		if (rhl && rhl.collider.gameObject.layer == 8 && !warning) {
			pm.suspectPenguin ();
			warning = true;
		} 
		else if (warning && !rhl) {
			pm.unsuspectPenguin ();
			warning = false;
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
