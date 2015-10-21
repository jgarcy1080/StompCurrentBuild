using UnityEngine;
using System.Collections;

public class MenusLoadLevel : MonoBehaviour {

	private GameObject StartGame, ExitApp;

	public Sprite SpriteSwap;
	private SpriteRenderer spriteRenderer;
	
	public AudioClip roar;
	AudioSource audio;



	void Start (){
				StartGame = GameObject.Find ("StartGame");
				ExitApp = GameObject.Find ("ExitApp");
			
				spriteRenderer = GetComponent<SpriteRenderer>();
				audio = GetComponent<AudioSource>();
		}


	IEnumerator CountDown(float timeToWait){
		yield return new WaitForSeconds(timeToWait);
	}
	IEnumerator OnMouseDown() {
		if (gameObject.name=="StartGame"){
			audio.PlayOneShot(roar, 1F);
			spriteRenderer.sprite = SpriteSwap;
			audio.PlayOneShot(roar, 1F);
			yield return StartCoroutine(CountDown(2));{
			Application.LoadLevel(1);
			}



			 if(gameObject.name=="ExitApp"){
			spriteRenderer.sprite = SpriteSwap;
			Application.Quit();
		}
}


}
}