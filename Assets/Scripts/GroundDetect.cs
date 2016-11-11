using UnityEngine;
using System.Collections;

public class GroundDetect : MonoBehaviour {

	/**
	 * Detects when the penguin is grounded
	 * */

     PenguinController character;

    void Start()
    {
        character = transform.parent.gameObject.GetComponent<PenguinController>();
    }

    private bool isGround(Collider2D c)
    {
        return true;
    }

	void OnTriggerEnter2D(Collider2D c)
    {

		if (character && (c.gameObject.layer == 9 || c.gameObject.layer == 10|| c.gameObject.layer == 15))
        {
			if (!character.groundHitYN && GetComponent<AudioSource> ()!=null)
				GetComponent<AudioSource> ().Play ();
            character.groundHitYN = true;
        }
    }

	void OnTriggerStay2D(Collider2D c)
    {

		if (character && (c.gameObject.layer == 9 || c.gameObject.layer == 10|| c.gameObject.layer == 15))
        {
            character.groundHitYN = true;
        }
    }

	void OnTriggerExit2D(Collider2D c)
    {

		if (character && (c.gameObject.layer == 9 || c.gameObject.layer == 10|| c.gameObject.layer == 15))
        {
            character.groundHitYN = false;
        }
    }
}

