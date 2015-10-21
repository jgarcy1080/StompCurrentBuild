using UnityEngine;
using System.Collections;

public class LoadScreens : MonoBehaviour {

	public IEnumerator Start()
	{
			yield return StartCoroutine(WaitASec(8)); // wait 5 seconds before loading new scene.
			Application.LoadLevel(2);

	}

	public IEnumerator WaitASec(float timeToWait)
	{
		yield return new WaitForSeconds(timeToWait);
	}
}



