using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {


    public Text scoreText;
	public static int score;

    void Start ()
    {
		UpdateScore ();
        score = 0;
		//scoreText= GetComponent<Text> ();

    }
	
	// Update is called once per frame
	void Update ()
    {
		DontDestroyOnLoad (this.gameObject);

	}

	public void AddScore (int NewScoreValue, bool reset)
	{
		score += NewScoreValue;
		UpdateScore ();

		if (reset) 
		{
			ResetScore ();
		}
	}

	public void UpdateScore()
	{
		scoreText.text = "Score :" + score;
	}

	public void ResetScore()
	{
		score = 0;
	}


}
