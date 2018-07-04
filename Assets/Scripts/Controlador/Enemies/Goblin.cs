using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour {

    Vector3 direction = new Vector3(0, 0, 1);
	Vector3 goblinScale = new Vector3 (1, 1, 1);
    Modelo speed = new Modelo();


    // Move it along its direction.
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed.MoveSpeed);
		transform.localScale = goblinScale;
    }


    // If we hit a left or right wall, invert x direction.
    void OnCollisionEnter(Collision col)
    {
        //var tag = hit.gameObject.tag;
		if (col.gameObject.tag == "rightwall" || col.gameObject.tag == "leftwall") 
		{
			direction.z *= -1;
			goblinScale.z *= -1;

		}
         
        
    }
}
