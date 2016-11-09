using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PenguinController : Grounded
{

    Rigidbody2D r;
	SpriteRenderer sr;

	private bool facingright;

    public float accel;
    public float maxspeed;
	public GameObject sprite;

	private Dictionary<string, Sprite> penguinCostumes;

    // Use this for initialization
    void Start()
    {
		facingright = true;
        r = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer> ();
        groundHitYN = false;
		loadPenguinCostumes ();
		LevelManager.onDeath += stop;
		LevelManager.onFinish += stop;
	}

	/**
	 * loadPenguinCostumes
	 * All penguin skins are loaded to be able to update the sprite accordingly
	 */
	void loadPenguinCostumes()
	{
		penguinCostumes = new Dictionary<string, Sprite>();

		penguinCostumes.Add("noCostume", (Sprite) Resources.Load("Skins/penguin_noCostume", typeof(Sprite)));
		penguinCostumes.Add("Hat", (Sprite) Resources.Load("Skins/penguin_Hat", typeof(Sprite)));
		penguinCostumes.Add("Tie", (Sprite) Resources.Load("Skins/penguin_Tie", typeof(Sprite)));
		penguinCostumes.Add("HatAndTie", (Sprite) Resources.Load("Skins/penguin_HatAndTie", typeof(Sprite)));

		sr.sprite = penguinCostumes["noCostume"];
	}

	/**
	 * Freezes movement; used when the level ends or the player fails.
	 * */
	private void stop(){
		gameObject.GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
	}

	/**
	 * dressUp
	 * Updates penguin skin
	*/
	public void dressUp(string type){
		if (penguinCostumes.ContainsKey (type)) 
		{
			sprite.GetComponent<SpriteRenderer>().sprite = penguinCostumes [type];
		}
	}

	void OnDestroy(){
		LevelManager.onDeath -= stop;
		LevelManager.onFinish -= stop;
	}

    // Update is called once per frame
    void Update()
    {


		//Movement controls
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Walk(transform.right * accel);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
			
            Walk(-transform.right * accel);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Jump();
        }
    }

	private void flip(GameObject o){

		float x = o.transform.localScale.x;
		float y = o.transform.localScale.y;
		facingright = !facingright;

		o.transform.localScale = new Vector2 (-x, y);
	}

    void LateUpdate()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D> ();
		float y = vel.velocity.y;
		float x = vel.velocity.x;


		//flip the sprite based upon the direction of movement
		if (facingright && GetComponent<Rigidbody2D> ().velocity.x < -0.1) 
		{
			flip (sprite);
		//	GetComponent<SpriteRenderer>().flipX=true; 
		}
		else if (!facingright && GetComponent<Rigidbody2D>().velocity.x >= 0.1) 
		{ 
			flip (sprite);
			//GetComponent<SpriteRenderer>().flipX = false; 
		}

		//cap velocity at maxspeed
		vel.velocity = x > maxspeed ? new Vector2(maxspeed,y) : x < -maxspeed ? new Vector2(-maxspeed,y) : vel.velocity;

    }

	//Walk by adding a force in the direction of movement
    private void Walk(Vector2 dir)
    {
        r.AddForce(dir, ForceMode2D.Force);
    }

	//Jump by adding a force upwards
    private void Jump()
    {
        if (groundHitYN)
        {
			GetComponent<AudioSource> ().Play ();   
            r.AddForce(transform.up * 300, ForceMode2D.Force);
        }
    }

    

}

