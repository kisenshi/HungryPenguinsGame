using UnityEngine;
using System.Collections;

public class PersonSolidAhead : MonoBehaviour {

    public Grounded person;

    // Use this for initialization
    void Start()
    {
        if (person.gameObject.layer == 11) person = transform.parent.gameObject.GetComponent<PersonMovement>();
    }

    void OnTriggerEnter2D(Collider2D c)
    {

        if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10))
        {
            person.groundHitYN = false;
        }
    }

    void OnTriggerStay2D(Collider2D c)
    {

        if (person && (c.gameObject.layer == 9 || c.gameObject.layer == 10))
        {
            person.groundHitYN = false;
        }
    }
}
