using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GUIHealthScript : MonoBehaviour {
	
	
	void Update () {
		Image image = GetComponent<Image>();
		image.fillAmount = GameManager.playerHealth / 100;
	}
}