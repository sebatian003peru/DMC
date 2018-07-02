using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    //public enum TileType {
    //typeA, typeB, typeC
    //}

    //public int minTile =0;
    //public int maxTile =1;
    //public GameObject[] tiles;
    //public TileType[] pattern;

    bool selfDestruct = false;
    public GameObject[] roomAvalaible;
    public GameObject testing;
    int roomIndex;
    public Transform roomSpawn;
	public int scoreValue=10;
    public int totalRoomsSpawned = 0;


	void Start()
	{
		roomSpawn = GameObject.FindGameObjectWithTag ("roomSpawner").transform;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerateStage();
        }

        if (totalRoomsSpawned >= 1)
        {
            Destroy(this.gameObject);

        }
    }


        void OnTriggerEnter(Collider col)
        {
            if (col.gameObject.tag == "Player")
            {
			ScoreController.score += scoreValue;
                GenerateStage();

            }

        }
    


	public void GenerateStage()
	{
        
        roomIndex = Random.Range(0,roomAvalaible.Length);
		//Vector3 starPosition = roomSpawn.transform.position;
		//Vector3 position = starPosition;
		//Quaternion rotation = transform.rotation;
		GameObject clone = Instantiate(roomAvalaible[roomIndex], roomSpawn.position, roomSpawn.rotation);
        //position = clone.transform.Find("exit").position;
        //rotation = clone.transform.Find("exit").rotation;
        totalRoomsSpawned += 1;
        //foreach(int p in pattern){	
        //GameObject tile = tiles[p];
        //GameObject clone = Instantiate(tile, position, rotation);
        //selfDestruct = true;
		roomSpawn.position += new Vector3(52,0,0);

		GameObject[] dangerobj = GameObject.FindGameObjectsWithTag ("danger");
		for (int i =0; i< dangerobj.Length; i++)
		{
			Destroy (dangerobj [i]);
		}

		GameObject[] trapobj = GameObject.FindGameObjectsWithTag ("trap");
		for (int i =0; i< trapobj.Length; i++)
		{
			Destroy (trapobj [i]);
		}

    }


	}






