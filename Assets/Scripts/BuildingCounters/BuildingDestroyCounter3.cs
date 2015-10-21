using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter3 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount3 += countBuilding;
		
		
	}
	
}
