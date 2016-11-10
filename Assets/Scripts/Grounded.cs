using UnityEngine;
using System.Collections;

public abstract class Grounded : MonoBehaviour {

	public bool groundHitYN;
    //{
      //  get; set;
   // }

    void Start()
    {
        groundHitYN = false;
    }
}
