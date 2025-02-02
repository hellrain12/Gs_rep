using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetSkin : MonoBehaviour
{
	public GameObject check;
	private void Update()
	{
		if( PlayerPrefs.GetInt( "snow" ) == 1 )
		{
			check.SetActive( true );
		}
	}
	public void GetSkinButton()
	{
		if( PlayerPrefs.GetInt( "gift" )>= 200)
		{
			PlayerPrefs.SetInt( "snow", 1 );
		}
	}
}
