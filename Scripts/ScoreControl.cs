using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
	public Text scoreText;
	public int score;
	public float time;
	private float timeStart = 0.2f;
	public float plus_score;


    void Update()
    {
		time -= Time.deltaTime;
		if(time<=0)
		{
			ScoreManager.score += plus_score;

			time = timeStart;
		}
    }
}
