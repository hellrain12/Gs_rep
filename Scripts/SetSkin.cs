using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
	public GameObject[] all_skin;
	private int setskin;
	private void Start()
	{
		setskin = PlayerPrefs.GetInt( "SetSkin" );
		all_skin[setskin].SetActive( true );
	}
}
