using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GUIScoreScript : MonoBehaviour {
	
	//public GameObject vialImage;
	//public static float buildingsTillMega = 5f;

	void Awake () {

	}

	void Update () {
		Image image = GetComponent<Image>();
		image.fillAmount = GameManager.playerScore / 200;
		Debug.Log("current image.fillAmount is: " + image.fillAmount);
	
	}
}