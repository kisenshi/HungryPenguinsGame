using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class LevelManager{

	public static int nTotalFish =0;
	public static int nCollectedFish =0;
	public static int nLevel;
	public static string nextLevelTag;
	private static LevelData ld;


	public delegate void gameEvent();
	public static event gameEvent resume;
	public static event gameEvent onCollect;
	public static event gameEvent onDeath;
	public static event gameEvent onFinish;




	public static void initialize(){
		ld = GameObject.Find ("LevelData").GetComponent<LevelData> ();
		nTotalFish = ld.nTotalFish;
		nCollectedFish = 0;
		nextLevelTag = ld.nextLevelTag;

	}

	public static bool isFinal(){
		return ld.finalLevel;

	}

	public static void closeMenus(){
		if (resume != null) resume();
	}

	public static void collectFish()
	{
		nCollectedFish ++;
		if (onCollect != null) onCollect();

	}

	public static void lose(){
		if (onDeath != null) onDeath();
	}

	public static void win(){
		if (onFinish != null) onFinish();
	}

	public static bool isLevelCompleted()
	{
		return nCollectedFish >= nTotalFish;
	}

	public static void restartLevel(){
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}

	public static void LoadNextLevel(){
		SceneManager.LoadScene(nextLevelTag, LoadSceneMode.Single);
		//initialize ();
	}
		

}
