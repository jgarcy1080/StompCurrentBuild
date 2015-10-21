using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndLevel3 : MonoBehaviour {

	public Image FadeImg;
	public float fadeSpeed = 1.5f;

	void FadeToBlack()
	{
		// Lerp the colour of the image between itself and black.
		FadeImg.color = Color.Lerp(FadeImg.color, Color.black, fadeSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player" && GameManager.playerScore >= 200)	
		{
			Application.LoadLevel(0);	



				// Make sure the RawImage is enabled.
				FadeImg.enabled = true;
				
				// Start fading towards black.
				FadeToBlack();
				
				// If the screen is almost black...
				//	if (FadeImg.color.a >= 0.95f)
				// ... reload the level
				//		Application.LoadLevel(SceneNumber);



			return;	
		}

		if(other.tag == "Player" && GameManager.playerScore < 200)
		{
			Application.LoadLevel(0);	
		
			return;	

		}

	}
}
