using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class megaCooldown : MonoBehaviour {


	public static float timeStamp;  //timeStamp variable used to mark the current time + the amount of seconds required
							  //the cooldown
	public float coolDownPeriodInSeconds;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(GameManager.megaCounter >= GUIMegaScript.buildingsTillMega){
			timeStamp = Time.deltaTime + coolDownPeriodInSeconds;
			Image image = GetComponent<Image>();
			image.fillAmount = Time.deltaTime / timeStamp;
		}

	
	}
}
