using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuAudio : MonoBehaviour
{

	public bool pauseActivated = false;

	void Update()
	{
		if (pauseActivated)
			Pause ();
		else
			Resume ();
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
		if (value==true)
			pauseActivated = true;
		if (value == false)
			pauseActivated = false;
	}





   

}