using UnityEngine;
using System.Collections;

public class megaParticles : MonoBehaviour {




	// Update is called once per frame
	void Update () {
		if(GameManager.megaCounter >= GUIMegaScript.buildingsTillMega){

		var exp = GetComponent<ParticleSystem>(); 
		exp.Play ();
		Destroy(gameObject,GetComponent<ParticleSystem>().duration);
		  	

		}
		
	}

}



