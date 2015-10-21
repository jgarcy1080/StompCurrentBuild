using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class hudScore : MonoBehaviour {
	//allows us to access the GUT Text Game Object and change it's contents
	public GameObject GUITextObject; 
	Text txt; 	
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		txt = GUITextObject.GetComponent<Text>();
		txt.text = GameManager.playerScore + " of " + 200;

	}
}