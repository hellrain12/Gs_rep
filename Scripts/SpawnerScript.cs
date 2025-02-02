using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
	public GameObject[] obj_spawns;
	private int random_spawn;
	[SerializeField] private int max_random;
	[SerializeField] private float spawn_cooldown;
	//время между спавнами легких препятствий
	public float spawn_cooldown_standart;
	//время между спавнами тяжелых препятствий
	public float spawn_cooldown_pro;

	public Transform spawn_enemy;
	public GameObject enemy;
	private void Start()
	{
		StartInvoke();
	}
	void StartInvoke()
	{
		InvokeRepeating( "Spawn", spawn_cooldown, spawn_cooldown );
	}
	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			spawn_cooldown = spawn_cooldown_standart;
			Instantiate( obj_spawns[random_spawn].gameObject ).gameObject.tag = "clone";
		}
	}

	void Spawn()
	{
		random_spawn = Random.Range( 1, max_random );

		if ( obj_spawns[random_spawn].gameObject.tag == "normal" )
		{
			CancelInvoke( "Spawn" );
			spawn_cooldown = spawn_cooldown_standart;
			Instantiate( obj_spawns[random_spawn] ).transform.position = this.transform.position;
			StartInvoke();
		}
		else if ( obj_spawns[random_spawn].gameObject.tag == "hard" )
		{
			CancelInvoke( "Spawn" );
			spawn_cooldown = spawn_cooldown_pro;
			Instantiate( obj_spawns[random_spawn] ).transform.position = this.transform.position;
			StartInvoke();
		}
		else if ( obj_spawns[random_spawn].gameObject.tag == "enemy" )
		{
			CancelInvoke( "Spawn" );
			spawn_cooldown = spawn_cooldown_standart;
			enemy.transform.position = spawn_enemy.transform.position;
			enemy.SetActive( true );
			StartInvoke();
			//Instantiate( obj_spawns[random_spawn] ).transform.SetParent(spawn_enemy.transform);
		}
		

	}

}
