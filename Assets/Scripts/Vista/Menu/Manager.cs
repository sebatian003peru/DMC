using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour {

	public string sceneName;
    public GameObject MainMenu;
    public GameObject Optiones;
    public GameObject Salida;


	public void Load()
	{
		SceneManager.LoadScene (sceneName);
        
	}
    
    public void StartGame()
    {
        SceneManager.LoadScene (sceneName);
        Optiones.SetActive(true);
    }
    

    public void Options()
    {
        Optiones.SetActive(true);
        MainMenu.SetActive(false);
    }

    public void Exit()
    {
        Salida.SetActive(true);
        Application.Quit();
    }


}
