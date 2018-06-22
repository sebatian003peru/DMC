using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnLoad : MonoBehaviour {
    Manager manager;
	// Use this for initialization
	void Start () {
        GameObject.Find("Music").SetActive(false);
        if (manager.sceneName == "Test")
        {
            GameObject.Find("Music").SetActive(true);
        }
    }
	
}
