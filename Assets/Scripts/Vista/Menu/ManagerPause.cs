using UnityEngine;
using UnityEngine.UI;

public class ManagerPause : MonoBehaviour {

    public Slider Volume;
    public AudioSource Music;
    AudioClip currentTrack;
    public bool pauseActivated = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Music.volume = Volume.value;

        if (pauseActivated)
            Pause();
        else
            Resume();
    }

    public void Pause()

    {
        p_movement.InputActive = false;
        Time.timeScale = 0;
    }


    public void Resume()
    {
        p_movement.InputActive = true;
        Time.timeScale = 1;
    }

    public void EffectOn(bool value)
    {
        if (value == true)
            pauseActivated = true;
        if (value == false)
            pauseActivated = false;
    }
}
