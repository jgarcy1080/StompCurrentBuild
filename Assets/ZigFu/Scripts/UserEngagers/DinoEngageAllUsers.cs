using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DinoEngageAllUsers : MonoBehaviour {
	
	public GameObject InstantiatePerUser;
	public GameObject MegaInstantiatePerUser;
	Dictionary<int, GameObject> objects = new Dictionary<int, GameObject>();
	
	void Zig_UserFound(ZigTrackedUser user) 
	{
		GameObject o = Instantiate(InstantiatePerUser) as GameObject;
		objects[user.Id] = o;
		user.AddListener(o);

		/*//Changing to Mega Kaiju
		if(GameManager.megaCounter >= GUIMegaScript.buildingsTillMega){
			Destroy(objects[user.Id]);
			objects.Remove (user.Id);
			GameObject mega = Instantiate(MegaInstantiatePerUser) as GameObject;
			objects[user.Id] = mega;
			user.AddListener(mega);
			if (megaCooldown.timeStamp <= Time.deltaTime){
				Destroy(objects[user.Id]);
				objects.Remove (user.Id);
				objects[user.Id] = o;
				user.AddListener(o);
				GameManager.megaCounter = 0f;
			}
		}
		*/
	}

	void Zig_UserLost(ZigTrackedUser user)
	{

		Destroy(objects[user.Id]);
		objects.Remove(user.Id);
	}
}
