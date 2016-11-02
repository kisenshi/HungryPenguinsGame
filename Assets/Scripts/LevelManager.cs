using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public int nTotalFish;
	public int nCollectedFish {
		get;
		private set;
	}

	void Start(){
		nCollectedFish = 0;
		CollectFish.onCollect += collectFish;
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
