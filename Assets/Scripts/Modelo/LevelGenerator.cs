using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {


   
    public GameObject[] roomAvalaible;
    int roomIndex;
    public Transform roomSpawn;
	public int scoreValue=10;
    public int totalRoomsSpawned = 0;
	private ScoreController sc;

	void Start()
	{
		GameObject gameScoreManager = GameObject.FindGameObjectWithTag ("scoreMana");
		roomSpawn = GameObject.FindGameObjectWithTag ("roomSpawner").transform;

		if (gameScoreManager != null)
		{
			sc = gameScoreManager.GetComponent<ScoreController>();

		}
		if (gameScoreManager == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}

		//sc.AddScore (scoreValue, true);
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

		sc.AddScore (scoreValue, false);


    }


	}






