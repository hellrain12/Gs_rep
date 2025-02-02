using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour
{
	public float speed;
	public float speedSnowflake;
	private int Score;
	public float time;
	private float timeStart = 0.2f;
	public SpawnerScript spawn_script;
	public ScoreControl score_script;
	private void Start()
	{
		Time.timeScale = 1f;
	}
	void Update()
	{
		time -= Time.deltaTime;
		if ( time <= 0 )
		{
			Score += 1;

			time = timeStart;
		}
		if(Score >= 25)
		{
			Score -= 25;
			speed += 0.4f;
			spawn_script.spawn_cooldown_pro -= 0.08f;
			spawn_script.spawn_cooldown_standart -= 0.08f;
			score_script.plus_score += 0.02f;
		}
	}
}
