using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter7 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount7 += countBuilding;
		
		
	}
	
}
