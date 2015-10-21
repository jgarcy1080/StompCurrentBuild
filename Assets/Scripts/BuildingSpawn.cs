using UnityEngine;
using System.Collections;

public class BuildingSpawn: MonoBehaviour {
	public Transform prefab;
	void Example() {


			Instantiate(prefab, new Vector3(2.0F, 0, 0), Quaternion.identity);


	}
}
