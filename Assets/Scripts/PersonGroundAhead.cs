using UnityEngine;
using System.Collections;

public class PersonGroundAhead : MonoBehaviour {

    public Grounded person;
	private int grounds;

    void Start()
    {
		grounds = 0;
        if (person.gameObject.layer == 8) person = transform.parent.gameObject.GetComponent<PenguinController>();
        else if (person.gameObject.layer == 11) person = transform.parent.gameObject.GetComponent<PersonMovement>();

	}

	void Update(){
		updateGrounded ();
	}
    private bool isGround(Collider2D c)
    {
        return true;
    }

	void OnTriggerEnter2D(Collider2D c)
    {

		if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10|| c.gameObject.layer == 15))
		{grounds++;
			
           // person.groundHitYN = true;
        }
    }

	void updateGrounded(){
		person.groundHitYN = grounds > 0 ? true : false;
	}

    void OnTriggerStay2D()
    {

        if (person)
        {
            //person.groundHitYN = true;
        }
    }

	void OnTriggerExit2D(Collider2D c)
    {

		if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10|| c.gameObject.layer == 15))
		{grounds--;

        }
    }
}
