using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter8 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount8 += countBuilding;
		
		
	}
	
}
