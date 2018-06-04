using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerE : MonoBehaviour {

	public GameObject entity;
	int test;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		spawn ();

		if (test == 1) 
		{
			Destroy (this.gameObject);
		}
	}

	void spawn()
	{
		Instantiate (entity, transform.position, transform.rotation);
		test+=1;
	}
}
