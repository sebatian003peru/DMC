using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour {

    public float breakingtime;
    public float decayTime;
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
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            decayTime += Time.deltaTime;
    }

}
