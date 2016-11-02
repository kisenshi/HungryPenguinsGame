using UnityEngine;
using System.Collections;

public class CollectFish : MonoBehaviour {

    public delegate void collect();
    public static event collect onCollect;



    void OnTriggerEnter2D(Collider2D c)
    {

        if (c.gameObject.name == "Penguin")
        {
            if (onCollect != null) onCollect();
            Destroy(this.gameObject);
        }
    }
}
