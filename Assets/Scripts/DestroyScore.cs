using UnityEngine;
using System.Collections;

public class DestroyScore : MonoBehaviour {

	public int DestructionValue = 10;

	// Use this for initialization
	void Start () {
		GameManager.playerScore += DestructionValue;


	}
	
	// Update is called once per frame
	void Update () {


	
	}
}
