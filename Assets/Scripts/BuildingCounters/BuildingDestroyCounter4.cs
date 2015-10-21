using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter4 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount4 += countBuilding;
		
		
	}
	
}
