﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FishDisplay : MonoBehaviour {

	public GameObject levelManager;

	private LevelManager lm;
	private bool updateNextFrame;

	// Use this for initialization
	void Start () {
		lm = levelManager.GetComponent<LevelManager>();

		updateNextFrame = true;
		setCollected ();

		CollectFish.onCollect += setCollected;
	
	}
	
    void setCollected()
    {
		updateNextFrame = true;
    }

	void Update(){
		if (updateNextFrame) {
			GetComponent<Text> ().text = lm.nCollectedFish + " / " + lm.nTotalFish;
			updateNextFrame = false;
		}
	}


	void OnDisable(){
		CollectFish.onCollect -= setCollected;
	}


}
