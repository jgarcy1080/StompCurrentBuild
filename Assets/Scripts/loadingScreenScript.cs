using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadingScreenScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {

		Image image = GetComponent<Image>();
		image.fillAmount = Application.GetStreamProgressForLevel(3) / 1;
		Debug.Log("current image.fillAmount is: " + image.fillAmount);

		if(Application.GetStreamProgressForLevel(3) == 1){
			Application.LoadLevel(3);

		}
	
	}

	public void LoadNextLevel(string name){
		StartCoroutine(LevelLoad(name));
	} 
	
	//load level after one sceond delay
	IEnumerator LevelLoad(string name){
		yield return new WaitForSeconds(10f);
		Application.LoadLevel(name);
	}
}
