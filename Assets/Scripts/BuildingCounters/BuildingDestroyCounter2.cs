using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter2 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount2 += countBuilding;
		
		
	}
	
}
