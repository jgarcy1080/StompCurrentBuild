using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter6 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount6 += countBuilding;
		
		
	}
	
}
