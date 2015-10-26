using UnityEngine;
using System.Collections;

public class Spawner {
	public virtual Monster spawnMonster(){ return null;}
}

public class SpawnerFor<T> : Spawner where T : Monster, new(){
	public override Monster spawnMonster()
	{
		return new T();
	}
}
