using UnityEngine;
using System.Collections;

public class BuildingDestroyCounter9 : MonoBehaviour {
	
	public int countBuilding = 1;
	
	// Use this for initialization
	void Start () {
		GameManager.bldgCount9 += countBuilding;
		
		
	}
	
}
