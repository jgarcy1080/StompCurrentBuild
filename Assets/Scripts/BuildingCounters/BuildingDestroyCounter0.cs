using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter0 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount0 += countBuilding;
		
		
	}
	
}
