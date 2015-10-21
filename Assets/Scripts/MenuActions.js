#pragma strict

var sprite002 : Sprite;  //will hold the sprite for the destroyed Play sign
var sprite003 : Sprite;  //will hold the sprite for the destroyed Exit sign
var bgmAudio : AudioSource;
var roarAudio : AudioSource;


function Start ()
{
	var aSources = GetComponents(AudioSource); bgmAudio = aSources[0]; roarAudio = aSources[1]; 
	if (!bgmAudio.isPlaying) bgmAudio.Play();
}

function OnTriggerEnter (mAction : Collider) {

	var oldSpriteObj : GameObject;  //This variable will hold the object the Sprite Renderers are on
	
	//Checks for to see if triggered object has the tag StartGame to load level 1
	if(mAction.CompareTag("StartGame")) {
		Debug.Log("SUTAAATOOO!");
		
		if (!roarAudio.isPlaying) roarAudio.Play();  //plays monster's roar, should play before level change
		
		//These 2 lines instantiate oldSpriteObj and then swaps the sprite on that object
		oldSpriteObj = GameObject.Find("SignDamage01");		
		oldSpriteObj.GetComponent(SpriteRenderer).sprite = sprite002;
		
		yield WaitForSeconds(1);  //this is supposed to give some time for the player to see the sprite change before loading the level
		bgmAudio.Stop();  //ends background music
		Application.LoadLevel(1);
	}
	
	//Checks to see if triggered object has ExitApp tag to exit the game
	else if(mAction.CompareTag("ExitApp")) {
		Debug.Log("Game exited...");
		
		if (!roarAudio.isPlaying) roarAudio.Play();  //plays monster's roar, should play before level change
		
		//These 2 lines instantiate oldSpriteObj and then swaps the sprite on that object
		oldSpriteObj = GameObject.Find("SignDamage02");		
		oldSpriteObj.GetComponent(SpriteRenderer).sprite = sprite003;
		
		yield WaitForSeconds(.25);  //this is supposed to give some time for the player to see the sprite change before exiting the game
		bgmAudio.Stop();  //ends background music
		Application.Quit();
	}
	
}
