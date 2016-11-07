using UnityEngine;
using System.Collections;

public class PushDetect : MonoBehaviour {

    private Rigidbody2D box;
    public bool stop { get; private set; }
    public GameObject otherside;

	// Use this for initialization
	void Start () {
        box = transform.parent.gameObject.GetComponent<Rigidbody2D>();
	}
	
    void Update()
    {
        stop = false;

    }

	void OnCollisionEnter2D(Collision2D c)
    {

        if (c.gameObject.layer == 8 && c.gameObject.GetComponent<PenguinController>().groundHitYN && !otherside.GetComponent<PushDetect>().stop)
        {
            box.constraints = RigidbodyConstraints2D.FreezeRotation;

        }

        else
        {
            box.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
            stop = true;
        }
    }

    void OnCollisionStay2D(Collision2D c)
    {
        stop = true;
    }

    void OnCollisionExit2D(Collision2D c)
    {



    }

}
