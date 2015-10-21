using UnityEngine;
using System.Collections;

public class PlaneActive : MonoBehaviour {

public GameObject child;
	//this is used to reference the child of DinoPerUSer	
	// Update is called once per frame


	void OnTriggerEnter (Collider other) {
		//DestroyObject (this.gameObject);
		if (other.tag == "PlaneActivator") {
			child.gameObject.SetActive(true);
		}
	}
	
}