using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getc : MonoBehaviour {

	public static GameObject[] getChildren (GameObject parent, bool recursive=false)
	{
		List<GameObject> iss = new List<GameObject>();
		for (int i = 0; i < parent.transform.childCount; i++) 
		{
			iss.Add (parent.transform.GetChild (i).gameObject);
			if (recursive){
				iss.AddRange (getChildren (parent.transform.GetChild (i).gameObject, recursive));
			}


			}
		return iss.ToArray();
		}

	public static Transform[] getTransform (GameObject parent)
	{
		List<Transform> ass = new List<Transform>();
		for (int i = 0; i < parent.transform.childCount; i++) 
		{
			ass.Add (parent.transform.GetChild (i).gameObject.transform);
		


		}
		return ass.ToArray();
	}
}
	


