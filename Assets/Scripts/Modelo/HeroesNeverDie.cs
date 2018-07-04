
using UnityEngine;

public class HeroesNeverDie : MonoBehaviour {
     
	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}
}
