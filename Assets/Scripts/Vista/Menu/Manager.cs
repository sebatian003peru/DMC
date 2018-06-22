using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour {

	public string sceneName;
    public GameObject meinMenu;
    public GameObject optiones;

	public void Load()
	{
		SceneManager.LoadScene (sceneName);
        
	}
    
    public void StartGame()
    {
        SceneManager.LoadScene (sceneName);
        optiones.SetActive(true);
    }
    

    public void Options()
    {
        optiones.SetActive(true);
        meinMenu.SetActive(false);
    }

    


}
