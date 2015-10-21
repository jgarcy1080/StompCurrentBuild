using UnityEngine;
using System.Collections;

public class Gas : MonoBehaviour {

	// GasBuildingDamage
	
	void OnTriggerEnter (Collider other) {
		///gas building
		if (other.tag == "Player") {
		
			GameManager.playerHealth -= 10;
		}
		
		
	}
}
