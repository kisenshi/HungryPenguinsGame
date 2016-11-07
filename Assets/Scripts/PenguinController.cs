using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PenguinController : Grounded
{

    Rigidbody2D r;
	SpriteRenderer sr;


    public float accel;
    public float maxspeed;

	private Dictionary<string, Sprite> penguinCostumes;

    // Use this for initialization
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
		sr = GetComponent<SpriteRenderer> ();
        groundHitYN = false;
		loadPenguinCostumes ();
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
	 * dressUp
	 * Updates penguin skin
	*/
	public void dressUp(string type){
		if (penguinCostumes.ContainsKey (type)) 
		{
			sr.sprite = penguinCostumes [type];
		}
	}

    // Update is called once per frame
    void Update()
    {
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

    void LateUpdate()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D> ();
		float y = vel.velocity.y;
		float x = vel.velocity.x;

		if (!sr.flipX && GetComponent<Rigidbody2D> ().velocity.x < -0.1) 
		{
			GetComponent<SpriteRenderer>().flipX=true; 
		}
        else if (sr.flipX && GetComponent<Rigidbody2D>().velocity.x >= 0.1) 
		{ 
			GetComponent<SpriteRenderer>().flipX = false; 
		}

		vel.velocity = x > maxspeed ? new Vector2(maxspeed,y) : x < -maxspeed ? new Vector2(-maxspeed,y) : vel.velocity;

    }

    private void Walk(Vector2 dir)
    {
        r.AddForce(dir, ForceMode2D.Force);
    }

    private void Jump()
    {
        if (groundHitYN)
        {
            
            r.AddForce(transform.up * 300, ForceMode2D.Force);
        }
    }

    

}

