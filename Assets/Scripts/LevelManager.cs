﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public int nTotalFish;
	public int nCollectedFish {
		get;
		private set;
	}
	public int nLevel;
	public string nextLevelTag;

	void Start(){
		nCollectedFish = 0;
		CollectFish.onCollect += collectFish;
		Debug.Log (nLevel);
		Debug.Log (nextLevelTag);
	}
		
	public void collectFish()
	{
		nCollectedFish ++;

	}

	public bool isLevelCompleted()
	{
		return nCollectedFish >= nTotalFish;
	}
}
