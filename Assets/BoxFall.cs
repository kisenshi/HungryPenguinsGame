﻿using UnityEngine;
using System.Collections;

public class BoxFall : MonoBehaviour {

	void LateUpdate(){
		Rigidbody2D vel = gameObject.GetComponent<Rigidbody2D>();
		float y = vel.velocity.y;
		float x = vel.velocity.x;

		if (y < -0)
			vel.velocity = new Vector2 (0, y);

	}
}
