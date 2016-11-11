using UnityEngine;
using System.Collections;

/**
 * Controls the behaviour of a Person, including the ability to move back and forth along a platform
 * */

public class PersonMovement : Grounded {

    public bool moving;	//true if the person is to move
    public float accel;	//acceleration rate
    public float maxSpeed;	//maximum speed
    public bool facingright
    {
        get; private set;
    }
	public bool solidahead{ get; set; }
	private Quaternion rotation;


	public GameObject warning;	//reference to sprite to display upon "too close" warning
	public GameObject exclamation;	//reference to sprite to display upon detection

	private int detections;
	private bool seen;

    public bool flipped;	//true if the person is to initially face left
    private Rigidbody2D r;


	public void seePenguin(){
		seen = true;
		updateSprite ();
	}

	public void suspectPenguin(){
		detections++;
		updateSprite ();
	}

	public void unsuspectPenguin(){
		detections--;
		updateSprite ();
	}
		
	private void updateSprite(){
		int i = detections > 0 ? 1 : 0;
		i = seen ? 2 : i;
		setSprite (i);
	}



	// Use this for initialization
	void Start () {

		rotation = gameObject.transform.rotation;

        if (flipped) flip();
        facingright = !flipped;
		seen = false;
		detections = 0;


		//if it's not supposed to move, freeze it in place
        if (!moving)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
        }
        
        //facingright = !gameObject.GetComponent<SpriteRenderer>().flipX;
        r = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

        if (moving)
        {
			//if there is ground ahead and nothing blocking movement
            if (groundHitYN && !solidahead)
            {
				//walk forward
                Vector2 dir = facingright ? transform.right : -transform.right;
                dir = dir * accel;
                Walk(dir);


            }

			else if(r.velocity.y==0)
            {
				//otherwise, turn around
                flip();
               

                //gameObject.GetComponent<SpriteRenderer>().flipX = !facingright;
            }

        }

	}



    void flip()
    {

        float x = transform.localScale.x;
        float y = transform.localScale.y;
        facingright = !facingright;

        transform.localScale = new Vector2(-x, y);

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);
    }

    void LateUpdate()
    {
		fixSpeed ();

    }

	public void setSprite(int i){

		switch (i) {

		case 0:
			warning.SetActive (false);
			exclamation.SetActive (false); break;
		case 1:
			warning.SetActive (true);
			exclamation.SetActive (false); 
			fixChildRotation (warning); break;
		case 2:
			warning.SetActive (false);
			exclamation.SetActive (true); 
			fixChildRotation (exclamation); break;
		default:
			warning.SetActive (false);
			exclamation.SetActive (false); break;


		}

	}

	private void fixChildRotation(GameObject o){
		float x = transform.localScale.x;
		float y = transform.localScale.y;

		float xo = o.transform.localScale.x;
		float yo = o.transform.localScale.y;

		xo = x*xo>0 ? xo : -xo;

		o.transform.localScale = new Vector2 (xo, y);
	}

	private void fixSpeed(){
		float y = r.velocity.y;
		float x = r.velocity.x;

		r.velocity = x > maxSpeed ? new Vector2(maxSpeed, y) : x < -maxSpeed ? new Vector2(-maxSpeed, y) : r.velocity;
	}

    private void Walk(Vector2 dir)
    {
		r.AddForce(dir, ForceMode2D.Impulse);
		fixSpeed ();
    }
}
