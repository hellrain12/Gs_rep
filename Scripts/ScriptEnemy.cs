using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptEnemy : MonoBehaviour
{
	private Transform player;
	public float speed = 2.0f;
	public Transform spawn_enemy;

	private void Update()
	{
		player = GameObject.FindGameObjectWithTag("player").transform;

			this.transform.SetParent( spawn_enemy.transform );
			Vector2 direction = (player.position - transform.position).normalized;

			transform.Translate( direction * speed * Time.deltaTime );
		
	}
}
