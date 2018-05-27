using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

	public Slider Volume;
	public AudioSource Music;
	AudioClip currentTrack;

	void Update () {
		
		Music.volume = Volume.value;

	}


}
