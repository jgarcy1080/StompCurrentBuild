using UnityEngine;
using System.Collections;

public class PlayBGMAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (!audio.isPlaying)
						audio.Play ();
	}
}
