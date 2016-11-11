using UnityEngine;
using System.Collections;

/**
 * Data container for level data
 * */

public class LevelData : MonoBehaviour {

	[SerializeField] public int nLevel;
	[SerializeField] public string nextLevelTag;	//name of next level to be loaded
	[SerializeField] public int nTotalFish;		//total fish in level
	public bool finalLevel;	//true if this is the final level and thus UI will be unloaded

	void Awake(){
		LevelManager.initialize ();
	}
}
