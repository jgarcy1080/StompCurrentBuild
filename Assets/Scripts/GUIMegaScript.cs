using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GUIMegaScript : MonoBehaviour {
	
	public GameObject vialImage;
	public static float buildingsTillMega = 5f;

	void Awake () {

	}

	void Update () {
		Image image = GetComponent<Image>();
		image.fillAmount = GameManager.megaCounter / buildingsTillMega;
		Debug.Log("current image.fillAmount is: " + image.fillAmount);
	
	}
}