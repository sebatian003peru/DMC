using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour {

    public float breakingtime;
    public float decayTime;
	public GameObject floorCol;
	bool activated;
    Animator Anim;
    [SerializeField]

	void Start () {
        Anim = GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        if (decayTime >= breakingtime)
        {
            Anim.SetBool("isFalling", true);
			Destroy (floorCol.gameObject);
			Destroy (this.gameObject,5);
        }

		if (activated) 
		{
			decayTime += Time.deltaTime;
		}
			
    }

    private void OnTriggerStay(Collider other)
    {
		if (other.gameObject.tag == "Player") {
			activated=true;

		}
		
    }

}
