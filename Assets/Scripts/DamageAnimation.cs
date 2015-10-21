using UnityEngine;
using System.Collections;

public class DamageAnimation : MonoBehaviour {
	Animator animator; //STEP 1 Set Variable for animator

	// Use this for initialization
/*	void Start () {
		animator = GetComponent <Animator>(); //STEP 2 - Get the compoonent
	}
	 
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.CompareTag("Gas"))
		{
			animator.SetBool ("Damage", true);
		}
		else{
			animator.SetBool ("Damage", false);
		}
*/


		
		
		
		// Use this for initialization
		void Start () {
			animator = GetComponent<Animator>();
		}
		
	
		
	void OnTriggerEnter (Collider other) {
		//DestroyObject (this.gameObject);
		if (other.tag == "Gas") {
			animator.SetTrigger("Damage1");
		}
	
	
		//DestroyObject (this.gameObject);
		if (other.tag == "PlaneShot") {
			animator.SetTrigger("Damage1");
		}
	
		//DestroyObject (this.gameObject);
		if (other.tag == "ColaTower") {
			animator.SetTrigger("ColaGlow");
		}
	
	
	}
}



	

	
