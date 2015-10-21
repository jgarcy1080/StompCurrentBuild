using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter5 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount5 += countBuilding;
		
		
	}
	
}
