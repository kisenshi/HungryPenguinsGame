using UnityEngine;
using System.Collections;

public class DiscoverPenguin : MonoBehaviour {

	public float sightDistance;
	public float warningDistance;

    void Update()
    {
        RaycastHit2D rh = Physics2D.Raycast(transform.position, transform.parent.gameObject.GetComponent<PersonMovement>().facingright ? transform.right : -transform.right, sightDistance, (1 << 8 | 1 << 9 | 1 << 10));
        if (rh && rh.collider.gameObject.layer == 8)
        {
            if (LevelManager.isPenguinDiscovered())
            {
                LevelManager.lose();

            }
        }

	//	RaycastHit2D rhl = Physics2D.Raycast(transform.position, transform.parent.gameObject.GetComponent<PersonMovement>().facingright ? transform.right : -transform.right, warningDistance, (1 << 8));
//		if (rhl & rhl.collider.gameObject.layer == 8) {

	//	}

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
