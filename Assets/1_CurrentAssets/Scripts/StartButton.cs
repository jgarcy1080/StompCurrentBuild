using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	private GameObject StartGame;

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
				StartGame = GameObject.Find ("StartGame");
				spriteRenderer = GetComponent<SpriteRenderer>();
				audio = GetComponent<AudioSource>();
		}


	IEnumerator CountDown(float timeToWait){
		yield return new WaitForSeconds(timeToWait);
	}
	IEnumerator OnMouseDown() {

			
			if (gameObject.name=="StartGame")
			{
				audio.PlayOneShot(roar, 1F);
				spriteRenderer.sprite = SpriteSwap;
				audio.PlayOneShot(roar, 1F);
				yield return StartCoroutine(CountDown(2));{
				Application.LoadLevel(1);
			}



		}

}


}

