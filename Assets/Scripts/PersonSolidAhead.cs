using UnityEngine;
using System.Collections;

/**
 * Detects whether a solid object is ahead of a Person, to allow him to turn back around
 * */

public class PersonSolidAhead : MonoBehaviour {

    public PersonMovement person;
	private int solids;

    // Use this for initialization
    void Start()
    {
		solids = 0;
        if (person.gameObject.layer == 11) person = transform.parent.gameObject.GetComponent<PersonMovement>();

    }

    void OnTriggerEnter2D(Collider2D c)
    {

        if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10))
        {
			updateState (1);
        }
    }

	private void updateState(int numSolids){
		solids += numSolids;
		person.solidahead = solids > 0 ? true : false;
	}

    void OnTriggerExit2D(Collider2D c)
    {

        if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10))
        {
			updateState (-1);
        }
    }
}
