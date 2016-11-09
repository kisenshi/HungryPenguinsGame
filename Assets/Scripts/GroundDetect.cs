using UnityEngine;
using System.Collections;

public class GroundDetect : MonoBehaviour {

     PenguinController character;

    void Start()
    {
        character = transform.parent.gameObject.GetComponent<PenguinController>();
    }

    private bool isGround(Collider2D c)
    {
        return true;
    }

    void OnTriggerEnter2D()
    {

        if (character)
        {
			if (!character.groundHitYN && GetComponent<AudioSource> ()!=null)
				GetComponent<AudioSource> ().Play ();
            character.groundHitYN = true;
        }
    }

    void OnTriggerStay2D()
    {

        if (character)
        {
            character.groundHitYN = true;
        }
    }

    void OnTriggerExit2D()
    {

        if (character)
        {
            character.groundHitYN = false;
        }
    }
}

