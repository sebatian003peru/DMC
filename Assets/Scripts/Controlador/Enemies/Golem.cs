using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : MonoBehaviour {

    public Transform Player;
    public float attackTime;
    public float elapsedAttack;
    Animator Anim;
   // Vector3 lookPos;




    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Anim = GetComponent<Animator>();
       // lookPos = Player.position - transform.position;
        //lookPos.y = 0;


    }
        
        void Update ()
    {

        //Quaternion rotation = Quaternion.LookRotation(lookPos);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);


        if (elapsedAttack >= attackTime)
            Anim.SetBool("isAttacking", true);


			
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            elapsedAttack += Time.deltaTime;
		    transform.LookAt(Player);
		    Anim.SetBool("isAttacking", true);
    }

    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag == "Player")
           // elapsedAttack = 0;
		
    }


}
