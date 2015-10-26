using UnityEngine;
using System.Collections;

public class Prototype : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Spawner ghostSpawner = new SpawnerFor<Ghost>();
		ghostSpawner.spawnMonster();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
