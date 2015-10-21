using UnityEngine;
using System.Collections;

public class CleanupScript : MonoBehaviour {
	
	void OnTriggerEnter(Collider other)
	{

		if(other.tag == "Buildings")
		{
			Debug.Log ("Destroy " + other);
			Destroy(other.gameObject);
		}

		if(other.tag == "PlaneEnemy")
		{
			Debug.Log ("Destroy " + other);
			Destroy(other.gameObject);
		}

		if(other.tag == "PlaneScroller")
		{
			Debug.Log ("Destroy " + other);
			Destroy(other.gameObject);
		}
		/*
		 * else
		{
			Destroy(other.gameObject);
		}
		*/
	}
}
