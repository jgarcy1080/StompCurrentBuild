using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameManager : MonoBehaviour 
{	
	public static float playerScore = 0f;
	public static int bldgCount0 = 0;
	public static int bldgCount1 = 0;
	public static int bldgCount2 = 0;
	public static int bldgCount3 = 0;
	public static int bldgCount4 = 0;
	public static int bldgCount5 = 0;
	public static int bldgCount6 = 0;
	public static int bldgCount7 = 0;
	public static int bldgCount8 = 0;
	public static int bldgCount9 = 0;

	public static float playerHealth = 100f;

	public int loseLevelSceneNum = 3;

	public static float megaCounter = 0f;

	//Testing KeyCodes
	public KeyCode HealthDecreaseKey;
	public KeyCode MegaIncreaseKey;

	//audio
	public GameObject ann1000;
	public GameObject ann2000;
	public GameObject ann5000;
	public GameObject getReady;






	

	//c# property to retrieve currently active instance of object, if any
	public static GameManager Instance
	{
		get
		{
			if (instance == null) instance = new GameObject ("GameManager").AddComponent<GameManager>(); //create game manager object if required
			return instance;
		}
	}
	
	//internal reference to single active instance of object - for singleton behavior
	public static GameManager instance = null;

	
	void Awake()
	{
		//Check if there is an existing instance of this object
		if((instance) && (instance.GetInstanceID () != GetInstanceID()))
			DestroyImmediate(gameObject); //delete duplicate
		else
		{
			instance = this; 						//make this object the only instance
			DontDestroyOnLoad (gameObject); 		//set as do not destoy
		}
	}
	
	void Start()
	{
		getReady.GetComponent<AudioSource>().Play();
	}

	void OnLevelWasLoaded(int level) {
		playerHealth = 100f;
		megaCounter = 0f;
		
	}




	void Update ()
	{ 
		//DEBUGING and TESTING Area**********

		//FOR DEBUG: HealthDecrease
		if (Input.GetKeyDown (HealthDecreaseKey)) {
			playerHealth -= 10;
		}

		if (Input.GetKeyDown (MegaIncreaseKey)){
			megaCounter++;
		}

		//Death Screen
		if (playerHealth <= 0) {
			Application.LoadLevel(loseLevelSceneNum);	
			return;
		}
		//Announcer for points
		if (playerScore <= 1000) {
			ann1000.GetComponent<AudioSource>().Play();
		}

		if (playerScore <= 2000) {
			ann1000.GetComponent<AudioSource>().Play();
		}

		if (playerScore <= 5000) {
			ann1000.GetComponent<AudioSource>().Play();
		}

			




		/*
		 * Debug.Log ("Player's Score is: " + playerScore);
		Debug.Log (bldgCount0 + " of Bldg0 Destroyed");
		Debug.Log (bldgCount1 + " of Bldg1 Destroyed");
		Debug.Log (bldgCount2 + " of Bldg2 Destroyed");
		Debug.Log (bldgCount3 + " of Bldg3 Destroyed");
		Debug.Log (bldgCount4 + " of Bldg4 Destroyed");
		Debug.Log (bldgCount5 + " of Bldg5 Destroyed");
		Debug.Log (bldgCount6 + " of Bldg6 Destroyed");
		Debug.Log (bldgCount7 + " of Bldg7 Destroyed");
		Debug.Log (bldgCount8 + " of Bldg8 Destroyed");
		Debug.Log (bldgCount9 + " of Bldg9 Destroyed");
		*/




	}
	



	public void PauseGame(){
		//enable the animator component
		//anim.enabled = true;
		//play the Slidein animation
		//anim.Play("PauseMenuSlideIn");
		//set the isPaused flag to true to indicate that the game is paused
		//isInfoPaused = true;
		//InfoMenu1.SetActive(true);
		//freeze the timescale
		//Time.timeScale = 0;
	}
	

	
	public void UnpauseGame(){
		//set the isPaused flag to false to indicate that the game is not paused
		//isInfoPaused = false;
		//{InfoMenu0.SetActive (false);}
		//{InfoMenu1.SetActive (false);}
		//{InfoMenu2.SetActive (false);}
		//{InfoMenu3.SetActive (false);}
		//{InfoMenu4.SetActive (false);}
		//Destroy (InfoMenu1);
		
		//play the SlideOut animation
		//anim.Play("InfoMenuSlideOut");
		//set back the time scale to normal time scale
		//Time.timeScale = 1;
	}
	
}