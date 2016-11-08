﻿using UnityEngine;
using System.Collections;

public class PersonMovement : Grounded {

    public bool moving;
    public float accel;
    public float maxSpeed;
    public bool facingright
    {
        get; private set;
    }
	public bool solidahead;

    public bool flipped;
    private Rigidbody2D r;

	// Use this for initialization
	void Start () {

        if (flipped) flip();
        facingright = !flipped;

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

            if (groundHitYN && !solidahead)
            {

                Vector2 dir = facingright ? transform.right : -transform.right;
                dir = dir * accel;
                Walk(dir);


            }

            else
            {
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
    }

    void LateUpdate()
    {
        float y = r.velocity.y;
        float x = r.velocity.x;

        r.velocity = x > maxSpeed ? new Vector2(maxSpeed, y) : x < -maxSpeed ? new Vector2(-maxSpeed, y) : r.velocity;
        r.velocity = groundHitYN ? r.velocity : new Vector2(0, y);

    }

    private void Walk(Vector2 dir)
    {
        r.AddForce(dir, ForceMode2D.Force);
    }
}