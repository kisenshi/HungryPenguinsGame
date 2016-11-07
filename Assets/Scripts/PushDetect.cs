using UnityEngine;
using System.Collections;

public class PushDetect : MonoBehaviour {

    private Rigidbody2D box;
    public bool stop { get; private set; }
    public GameObject otherside;
    public int blocking { get; private set; }
    public bool penguin { get; private set; }

	// Use this for initialization
	void Start () {
        box = transform.parent.gameObject.GetComponent<Rigidbody2D>();
        blocking = 0;
        penguin = false;
	}
	
    void Update()
    {
        if (penguin && otherside.GetComponent<PushDetect>().blocking == 0)
        {
            box.constraints = RigidbodyConstraints2D.FreezeRotation;
        }

        else if (!otherside.GetComponent<PushDetect>().penguin && blocking >0)
        {
            box.constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
        }

    }

	void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.layer == 9 || c.gameObject.layer == 10) { blocking++; }
        else if (c.gameObject.layer == 8)
        {
            penguin = true;

        }
        
    }

    void OnTriggerStay2D(Collider2D c)
    {

    }

    

    void OnTriggerExit2D(Collider2D c)
    {

        if (c.gameObject.layer == 9 || c.gameObject.layer == 10) blocking--;
        else if (c.gameObject.layer == 8) penguin = false; 

    }

}
