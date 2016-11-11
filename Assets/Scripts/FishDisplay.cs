using UnityEngine;
using UnityEngine.UI;
using System.Collections;


/**
 * Behaviour to display the number of fish collected and the max number in the level
 * */
public class FishDisplay : PersistentUIInterface {
	private bool updateNextFrame;

	protected override void myStart(){
		initialize ();
		LevelManager.onCollect += getFish;
	}

	void initialize(){
		updateNextFrame = true;
		setCollected ();
	}

	void getFish(){
		GetComponent<AudioSource> ().Play ();
		setCollected ();
	}

    void setCollected()
    {
		updateNextFrame = true;
    }

	void Update(){
		if (updateNextFrame) {
			GetComponent<Text> ().text = LevelManager.nCollectedFish + " / " + LevelManager.nTotalFish;
			updateNextFrame = false;
		}
	}

	protected override void myOnLevelWasLoaded(){
	
	}

	protected override void reset(){
		initialize ();
	}

	void OnDisable(){
		LevelManager.onCollect -= getFish;
	}


}
