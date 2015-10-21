using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter1 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount1 += countBuilding;
		
		
	}
	
}
