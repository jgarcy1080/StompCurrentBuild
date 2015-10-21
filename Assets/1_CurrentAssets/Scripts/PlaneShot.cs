using UnityEngine;
using System.Collections;
[RequireComponent (typeof(SphereCollider))]
public class PlaneShot : MonoBehaviour
{

		public int shotType; // 0 = bomb, 1= Bullet
	
		public float damage; 	//Damage projectile causes
		public float speed; 	//Speed at which projectile moves.
		public float shotScale;//Scale of projectile
		public float fullSize;	//Full scale of projectile that falls (i.e. Bomb)
		public float timer;	//Lifetime length of projectile
		
		public bool exploded; //Checks to see if a projectile has exploded
		
		SphereCollider collider; //Collider for bullet
		

		// Use this for initialization
		void Start ()
		{
				collider = GetComponent<SphereCollider> ();
				exploded = false;
				
				if (shotType == 0) {
						//Bomb
						speed = 1f;
						damage = 25f;
						fullSize = 5f;
						timer = Random.Range (5f, 25f);
						shotScale = 1f;
						gameObject.transform.localScale = new Vector3 (fullSize, fullSize, fullSize);
						//Set appearance of Projectile
				}

				if (shotType == 1) {
						//Bullet
						speed = -.8f;
						damage = 5f;
						fullSize = 1f;
						timer = 16f;
						shotScale = 1f;
						//Set appearance of Projectile
				}
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				Move ();
				Countdown ();
		}
		
		void Move ()
		{
				
				if (shotType == 0) {
						if (gameObject.transform.position.y >= fullSize / 2) {
								gameObject.transform.Translate (new Vector3 (0, -speed * Time.deltaTime, 0));
						}
						gameObject.transform.Translate (new Vector3 (0, 0, -speed * Time.deltaTime));
						if (shotScale <= fullSize) {
								shotScale -= 1f * Time.deltaTime;
								if (shotScale >= 0) {
										//	gameObject.transform.localScale = new Vector3 (shotScale, shotScale, shotScale);
								}
						}
				}
				if (shotType == 1) {
						gameObject.transform.Translate (new Vector3 (0, 0, speed));
				}
		}
		
		void Countdown ()
		{
				timer -= (1 * Time.deltaTime);
				if (timer <= 0) {
						ShotDeath ();
				}
		}
		
		void ShotDeath ()
		{
				if (shotType == 0) {
						if (exploded == false) {
								//WHEN VISUAL IMPLEMENTED UNCOMMENT
								//collider.radius *= 2;
								timer += .5f;
								exploded = true;
								//Any visual effect of explosion
								gameObject.transform.localScale = new Vector3 (fullSize * 2, fullSize * 2, fullSize * 2);
						} else {
								Destroy (gameObject);
						}
				}
				if (shotType == 1) {
				
						Destroy (gameObject);
				}
		}
		void OnTriggerStay (Collider col)
		{
				if (col.gameObject.tag == "Player") {
						ShotDeath ();
						GameManager.playerHealth -= damage;		
				}
				if (col.gameObject.name == "Clean Up Wall") {
						ShotDeath ();
			
				}
		}
}