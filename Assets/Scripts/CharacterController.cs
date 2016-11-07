using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

    Rigidbody2D r;

    public bool groundHitYN
    {
        get; set;
    }

    public float accel;
    public float maxspeed;


	// Use this for initialization
	void Start () {
	r = GetComponent<Rigidbody2D>();
        groundHitYN = false;

    }

    // Update is called once per frame
    void Update() {

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

        private void Walk(Vector2 dir)
    {
        r.AddForce(dir, ForceMode2D.Force);
    }

        private void Jump()
    {
        if (groundHitYN)
        {
            Debug.Log(groundHitYN);
            r.AddForce(transform.up * 250, ForceMode2D.Force);
        }
    }

    /**void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.name == "Fish") Destroy(c.gameObject);
    }**/

    }

