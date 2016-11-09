using UnityEngine;
using System.Collections;

public class PushDetect : MonoBehaviour {

    private WoodBox box;
    public bool stop { get; private set; }
    public GameObject otherside;
    public int blocking { get; private set; }
    public bool penguin { get; private set; }



	// Use this for initialization
	void Start () {
		box = transform.parent.GetComponent<WoodBox>();
        blocking = 0;
        penguin = false;
	}
	
    void Update()
    {
        if (penguin && otherside.GetComponent<PushDetect>().blocking == 0)
        {
			box.unFreeze ();
        }

		else if (!otherside.GetComponent<PushDetect>().penguin && blocking >0)
        {
			box.Freeze ();
        }
    }



	void OnTriggerEnter2D(Collider2D c)
    {




        if (c.gameObject.layer == 9 || c.gameObject.layer == 10 || c.gameObject.layer == 11) { blocking++; }
        else if (c.gameObject.layer == 8)
        {
            penguin = true;

        }
        
    }

    

    void OnTriggerExit2D(Collider2D c)
    {

        if (c.gameObject.layer == 9 || c.gameObject.layer == 10 || c.gameObject.layer ==11) blocking--;
        else if (c.gameObject.layer == 8) penguin = false; 

    }

}
