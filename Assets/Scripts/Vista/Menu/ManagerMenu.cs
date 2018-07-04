using UnityEngine.SceneManagement;
using UnityEngine;

public class ManagerMenu : MonoBehaviour {

	public string sceneName;
    public GameObject MainMenu;
    public GameObject Optiones;
    public GameObject Salida;
    public GameObject PauseToggle;

   
    public void Load()
	{
		SceneManager.LoadScene (sceneName);
        
	}
    
    public void StartGame()
    {
        SceneManager.LoadScene (sceneName);
        //Optiones.SetActive(true);
        PauseToggle.SetActive(true);
    }
    

    public virtual void Options()
    {
        MainMenu.SetActive(false);
        Optiones.SetActive(true);
        
    }

    public void Exit()
    {
        Salida.SetActive(true);
        Application.Quit();
    }


}
