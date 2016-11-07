using UnityEngine;
using System.Collections;

public class PersonGroundAhead : MonoBehaviour {

    public Grounded person;

    void Start()
    {
        if (person.gameObject.layer == 8) person = transform.parent.gameObject.GetComponent<PenguinController>();
        else if (person.gameObject.layer == 11) person = transform.parent.gameObject.GetComponent<PersonMovement>();
    }

    private bool isGround(Collider2D c)
    {
        return true;
    }

    void OnTriggerEnter2D()
    {

        if (person)
        {
            person.groundHitYN = true;
        }
    }

    void OnTriggerStay2D()
    {

        if (person)
        {
            person.groundHitYN = true;
        }
    }

    void OnTriggerExit2D()
    {

        if (person)
        {
            person.groundHitYN = false;
        }
    }
}
