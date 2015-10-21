using UnityEngine;
using System.Collections;

public class PlaneWarning : MonoBehaviour {
	public GameObject enemywave;
	// Use this for initialization
	


	void OnTriggerEnter (Collider other) {
		//DestroyObject (this.gameObject);
		if (other.tag == "PlaneScroller") {
			enemywave.GetComponent<AudioSource>().Play();
		}
		
		
	}




}