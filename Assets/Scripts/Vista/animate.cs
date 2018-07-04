using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.W)){
			anim.Play("Run",-1,0f);
		}
		if (Input.GetKeyUp(KeyCode.W)){
			anim.Play("Idle",-1,0f);
		}
	}
}
