using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform Player;

    Modelo speed = new Modelo();

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); 
    }

    void Update()
    {
        transform.LookAt(Player);
        transform.position += transform.forward * speed.MoveSpeed * Time.deltaTime;




        
    }

}
