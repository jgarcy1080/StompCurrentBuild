using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	//array for items to spawn
	public GameObject[] obj;
	//public Vector3 buildingSpawn;
	//public Transform trans;

	//how frequently to spawn items
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {

		Spawn();
	}
	
	// spawning function
	void Spawn () {
	
		Instantiate((obj[Random.Range(0, obj.GetLength(0))]), transform.position, Quaternion.identity);
		//Invoke("Spawn", Random.Range (spawnMin, spawnMax));

	}
}
