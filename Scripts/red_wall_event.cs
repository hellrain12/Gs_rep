using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class red_wall_event : MonoBehaviour
{
	public GameObject red;
	private void Update()
	{
		if(GameObject.FindGameObjectWithTag("event").GetComponent<eventScipt>().isEvent == true)
		{
			red.SetActive( true );
		}
		else
		{
			red.SetActive( false );
		}
	}
}
