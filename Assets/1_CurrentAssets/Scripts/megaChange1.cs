using UnityEngine;
using System.Collections;

public class megaChange1 : MonoBehaviour {

//	private Animator animator; //STEP 1 Set Variable for animator



	// Use this for initialization
/*	void Start () {
		animator = GetComponent <Animator>(); //STEP 2 - Get the compoonent
	

	}
*/	
	// Update is called once per frame
	void Update () {

		if(GameManager.megaCounter >= GUIMegaScript.buildingsTillMega){
			Destroy(gameObject);
/*		  	

		}
		else{
			animator.SetBool ("isMega", false);
		}
*/	
	}
}

}
	