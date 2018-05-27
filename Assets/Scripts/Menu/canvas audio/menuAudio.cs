using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuAudio : MonoBehaviour
{


			
	public void Pause()

	{
		Debug.Log(Time.timeScale);
		Time.timeScale = 0;
	}


    public void Resume()
    {
        
       
        Debug.Log(Time.timeScale);
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
       
    }





   

}