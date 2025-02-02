using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{
	public static int hideHints = 0;
	public GameObject on, off;
	public GameObject allHints;
	private void Start()
	{
		PlayerPrefs.GetInt( "hiH" );
		hideHints = PlayerPrefs.GetInt( "hiH" );
	}
	public void offHints()
	{
		hideHints = 0;
		on.SetActive( true );
		off.SetActive( false );
		PlayerPrefs.SetInt( "hiH", hideHints );
	}

	public void onHints()
	{
		hideHints = 1;
		on.SetActive( false );
		off.SetActive( true );
		PlayerPrefs.SetInt( "hiH", hideHints );
	}

	private void Update()
	{
		if(hideHints == 1)
		{
			allHints.SetActive( true);
			on.SetActive( false );
			off.SetActive( true );
		}

		if ( hideHints == 0 )
		{
			allHints.SetActive( false);
			on.SetActive( true );
			off.SetActive( false );
		}
	}
}
