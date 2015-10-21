using UnityEngine;
using System.Collections;

public class PlaneEnemy : MonoBehaviour
{

		public int planeType; // 0 = bomber, 1= shooter
	
		public float speed;
		public float ammo;
		public float damage;
		public float fireRate;
		
		public float fireCountdown = 0;
		
		public PlaneShot shot;
	

	

		// Use this for initialization
		void Start ()
		{
	
				if (planeType == 0) {
						//Bomber
						speed = .005f;
						ammo = 5f;
						damage = 10f;
						fireRate = 10f;
				}
				if (planeType == 1) {
						//Shooter
						speed = -.16f;
						ammo = 20f;
						damage = 10f;
						fireRate = 1f;
				}
		
		}
	
		// Update is called once per frame
		void Update ()
		{
				Move ();
				FireCountdown ();
	
		}
		
		void Move ()
		{
				gameObject.transform.Translate (new Vector3 (0, 0, speed));
		}
		
		void FireCountdown ()
		{
				if (ammo > 0) {
						fireCountdown += (1 * Time.deltaTime);
						if (fireCountdown >= fireRate) {
								fireCountdown = 0;
								FireShot ();
								ammo -= 1;
						}
				}
		}
		
		void FireShot ()
		{
				if (planeType == 0) {
						shot.shotType = 0;
						Instantiate (shot.gameObject, new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y - 10, gameObject.transform.position.z), Quaternion.identity);
				}
				if (planeType == 1) {
						shot.shotType = 1;
						Instantiate (shot.gameObject, gameObject.transform.position, Quaternion.identity);
				}
		}
		void PlaneDeath ()
		{
				//VISUAL EFFECT
				Destroy (gameObject);
		}
	
		void OnTriggerStay (Collider col)
		{
				if (col.gameObject.tag == "Player") {
						PlaneDeath ();
						GameManager.playerHealth -= damage;		
				}
				if (col.gameObject.name == "Clean Up Wall") {
						PlaneDeath ();
								
				}
		}
}
