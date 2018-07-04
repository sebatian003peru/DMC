using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject enemySpawnCollection;
	public GameObject trapSpawnCollection;
	/// <summary>
	public GameObject[] enemies;
	public GameObject[] spawns;
	int enemyIndex;
	int spawnIndex;
	/// <summary>
	public int numberOfEnemies;
	public int MaxnumberOfEnemies=5;
	public int numberOfTraps;
	/// <summary>
	public GameObject[] traps;
	public GameObject[] trapspawn;
	int trapIndex;
	int trapspawnIndex;

	void Awake()
	{
		spawns = GetChildren.getChildren (enemySpawnCollection, true);
		trapspawn = GetChildren.getChildren (trapSpawnCollection, true);
		numberOfEnemies = Random.Range (0, MaxnumberOfEnemies);
		numberOfTraps = MaxnumberOfEnemies - numberOfEnemies; 
	}

	void Start () 
	{

		placeEnemies ();
		placeTraps ();
		//Debug.Log (numberOfTraps);
	 
	}


	void spawnEntities()
	{
		Instantiate (enemies [Random.Range (0, enemyIndex)], spawns[Random.Range (0, spawnIndex)].transform.position, spawns[Random.Range (0, spawnIndex)].transform.rotation);
		Debug.Log ("duh");
		
	}

	void spawnTraps()
	{
		Instantiate (traps [Random.Range (0, trapIndex)], trapspawn[Random.Range (0, trapspawnIndex)].transform.position, trapspawn[Random.Range (0, trapspawnIndex)].transform.rotation);
		Debug.Log ("duh");
	}

	void placeEnemies()
	{
		enemyIndex = enemies.Length;
		spawnIndex = spawns.Length;

		for (int i = 0; i < numberOfEnemies; i++)
		{
			spawnEntities();
		}
	}

	void placeTraps()
	{
		trapIndex = traps.Length;
		trapspawnIndex = trapspawn.Length;

		for (int t = 0; t < numberOfTraps; t++)
		{
			spawnTraps();
		}
	}


}
