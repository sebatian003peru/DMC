using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuAudio : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject VolSlider;
    public bool paused = false;
    public bool pressed = false;


    void Start()
    {



        PauseUI.SetActive(false);

    }

    void Update()
    {

        if (Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if (paused)
        {
            Debug.Log(Time.timeScale);
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        /*if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }*/

    }

    public void Resume()
    {
        paused = false;
        PauseUI.SetActive(false);
        Debug.Log(Time.timeScale);
        Time.timeScale = 1;
        Debug.Log(Time.timeScale);
        VolSlider.SetActive(false);
    }

    public void VolShow()
    {
        VolSlider.SetActive(true);

    }



   

}