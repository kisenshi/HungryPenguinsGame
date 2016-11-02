using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FishDisplay : MonoBehaviour {

    public int fishes;
    public int collected
    {
        private set; get;
    }

	// Use this for initialization
	void Start () {
        CollectFish.onCollect += getFish;
        setCollected();
	
	}
	
    void setCollected()
    {
        GetComponent<Text>().text = collected + " / " + fishes;
    }

	void getFish()
    {
        collected++;
        setCollected();
    }
	
	
}
