using UnityEngine;
using System.Collections;

public class BSS: MonoBehaviour {
	public Transform prefab;

	void Start () {
		
		Spawn();
	}


	void Spawn() {


			Instantiate(prefab, new Vector3(0, 1f, 0), Quaternion.identity) ;
			
	}
}

