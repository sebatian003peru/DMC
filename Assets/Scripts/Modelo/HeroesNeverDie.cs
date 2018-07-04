
using UnityEngine;

public class HeroesNeverDie : MonoBehaviour {

    public static HeroesNeverDie Instance;

	// Use this for initialization
	void Awake () {

        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
	}
}
