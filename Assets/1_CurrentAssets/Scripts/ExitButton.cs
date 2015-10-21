using UnityEngine;
using System.Collections;

public class ExitButton : MonoBehaviour {

	private GameObject ExitApp;

	public Sprite SpriteSwap;
	private SpriteRenderer spriteRenderer;
	
	public AudioClip roar;
	AudioSource audio;

	private Color startcolor;
	void OnMouseEnter()
	{
		startcolor = renderer.material.color;
		renderer.material.color = Color.gray;
	}
	void OnMouseExit()
	{
		renderer.material.color = startcolor;
	}
	
		void Start (){
				ExitApp = GameObject.Find ("ExitApp");
				spriteRenderer = GetComponent<SpriteRenderer>();
				audio = GetComponent<AudioSource>();
		}


	IEnumerator CountDown(float timeToWait){
		yield return new WaitForSeconds(timeToWait);
	}
	IEnumerator OnMouseDown() {

			
			
				audio.PlayOneShot(roar, 1F);
				spriteRenderer.sprite = SpriteSwap;
				audio.PlayOneShot(roar, 1F);
				yield return StartCoroutine(CountDown(1));{
				Application.Quit();
			}





}


}

