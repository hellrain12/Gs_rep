using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
	private float speed;
	private GameObject speedCode_obj;
	private void Start()
	{
		speedCode_obj = GameObject.FindGameObjectWithTag( "SpeedManager" );
		
	}
	void Update()
    {
		if(Time.timeScale == 1)
		{
			transform.position += new Vector3( -speed / 1000, 0, 0 );
		}
		if ( this.gameObject.tag == "Snowflaker" )
		{
			speed = speedCode_obj.GetComponent<SpeedManager>().speedSnowflake;
		}
		if ( this.gameObject.tag != "Snowflaker" )
		{
			speed = speedCode_obj.GetComponent<SpeedManager>().speed;
		}
	}
}
