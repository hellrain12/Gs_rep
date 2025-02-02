using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawn : MonoBehaviour
{
	public GameObject[] obj_spawns;
	private int random_spawn;
	[SerializeField] private int max_random;
	[SerializeField] private float spawn_cooldown;
	private void Start()
	{
		InvokeRepeating( "Spawn", spawn_cooldown, spawn_cooldown );
	}

	void Update()
	{

	}

	void Spawn()
	{
		random_spawn = Random.Range( 1, max_random );
		Instantiate( obj_spawns[random_spawn] ).transform.position = this.transform.position;
	}
}
