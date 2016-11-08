using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class LevelManager{

	public static int nTotalFish =0;
	public static int nCollectedFish =0;
	public static bool done = false;
	public static int nLevel;
	public static string nextLevelTag;
	private static LevelData ld;

	public delegate void gameEvent();
	public static event gameEvent resume;
	public static event gameEvent onCollect;
	public static event gameEvent onDeath;
	public static event gameEvent onFinish;

	// NoCostume, Hat, Tie, HatAndTie
	public static string penguinCostume;

	/*
	* Initialized every element in the Level, loaded from the dynamic LevelData or set to the default values
	*/
	public static void initialize()
	{
		// The level Data set manually for each level is loaded to be used in the manager
		ld = GameObject.Find ("LevelData").GetComponent<LevelData> ();
		nTotalFish = ld.nTotalFish;
		nextLevelTag = ld.nextLevelTag;
		done = false;

		// The penguin starts the level with no collected fish and no costume
		nCollectedFish = 0;
		penguinCostume = "NoCostume";
	}

	/**
	 * isPenguinDiscovered
	 * Checks if the penguin is dressep up or not
	 * If it's not dressep up, its costume is still NoCostume
	 */
	public static bool isPenguinDiscovered()
	{
		return (penguinCostume == "NoCostume");
	}
		
	/**
	 * isFinal
	 * Checks if it's the final level
	 */
	public static bool isFinal(){
		return ld.finalLevel;
	}

	/**
	 * closeMenus
	 * Triggers the resume event
	 */
	public static void closeMenus(){
		if (resume != null) resume();
	}

	/**
	 * collectFish
	 * Called when the penguin collects a fish
	 * Triggers the onCollect event
	 */
	public static void collectFish()
	{
		nCollectedFish ++;
		if (onCollect != null) onCollect();
	}

	/*
	 * collectCostume
	 * Called when the penguin collects an object it will use to dress up
	 * The penguinCostume status is updated, and the correct sprite loaded
	 */
	public static void collectCostume(string type)
	{
		penguinCostume = type;
		PenguinController penguin = GameObject.Find("Penguin").GetComponent<PenguinController>();
		penguin.dressUp (type);
	}

	/**
	 * lose
	 * Triggers the onDeath event
	 */
	public static void lose(string msg="You failed!"){
		if (onDeath != null && !done) {
			done = true;
			onDeath ();
		}
	}

	/**
	 * win
	 * Triggers the onFinish event
	 */
	public static void win(){
		if (onFinish != null && !done) {
			done = true;
			onFinish ();
		}
	}

	/**
	 * isLevelCompleted
	 * It checks if the level has been completed.
	 * A level is completed when the penguin has collected enough fish.
	 */
	public static bool isLevelCompleted()
	{
		return nCollectedFish >= nTotalFish;
	}

	/**
	 * restartLevel
	 * Restarts the level reloading the current scene.
	 */
	public static void restartLevel(){
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}

	/**
	 * LoadNextLevel
	 * Loads the next level using the nextLevelTag set in the data for the level.
	 */
	public static void LoadNextLevel(){
		SceneManager.LoadScene(nextLevelTag, LoadSceneMode.Single);
	}
		

}
