using UnityEngine;
using System.Collections;

public abstract class Grounded : MonoBehaviour {

	/**
	 * Base class for objects that care about whether they are grounded
	 * */

	public bool groundHitYN
    {
        get; set;
    }

    void Start()
    {
        groundHitYN = false;
    }
}
