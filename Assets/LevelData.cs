using UnityEngine;
using System.Collections;

public class LevelData : MonoBehaviour {

	[SerializeField] public int nLevel;
	[SerializeField] public string nextLevelTag;
	[SerializeField] public int nTotalFish;

	void Start(){
		LevelManager.initialize ();
	}
}
