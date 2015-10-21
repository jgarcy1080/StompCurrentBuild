using UnityEngine;
using System.Collections;

public class MegaDestroyScore : MonoBehaviour {

	public int DestructionValue = 10;

	// Use this for initialization
	void Start () {
		GameManager.playerScore += DestructionValue;
		GameManager.megaCounter ++;


	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
