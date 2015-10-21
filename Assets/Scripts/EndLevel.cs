using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour {
	public int levelNum = 3;
	public GameObject audioObj;
	public int loseLevelSceneNum = 2;
	public static int goalScore = 200;
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && GameManager.playerScore >= goalScore)	
		{
			Application.LoadLevel(levelNum);	
			audioObj.audio.Play ();
			return;	
		}

		if(other.tag == "Player" && GameManager.playerScore < goalScore)
		{
			Application.LoadLevel(loseLevelSceneNum);	
			return;	
		}
	}
}
