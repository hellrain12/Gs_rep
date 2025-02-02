using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenProCompany : MonoBehaviour
{
	private int lvl1;
	private int lvl2;
	private int lvl3;
	private int lvl4;
	private int lvl5;
	private int lvl6;
	private int lvl7;
	private int lvl8;
	private int lvl9;
	private int lvl10;
	private int lvl11;
	private int lvl12;
	public GameObject check;
	public GameObject Lock;
	public GameObject buttonPlay;
	private void Start()
	{
		lvl1 = PlayerPrefs.GetInt( "1" );
		lvl2 = PlayerPrefs.GetInt( "2" );
		lvl3 = PlayerPrefs.GetInt( "3" );
		lvl4 = PlayerPrefs.GetInt( "4" );
		lvl5 = PlayerPrefs.GetInt( "5" );
		lvl6 = PlayerPrefs.GetInt( "6" );
		lvl7 = PlayerPrefs.GetInt( "7" );
		lvl8 = PlayerPrefs.GetInt( "8" );
		lvl9 = PlayerPrefs.GetInt( "9" );
		lvl10 = PlayerPrefs.GetInt( "10" );
		lvl11 = PlayerPrefs.GetInt( "11" );
		lvl12 = PlayerPrefs.GetInt( "12" );
	}
	private void Update()
	{
		if(lvl1+lvl2+lvl3+ lvl4+ lvl5 + lvl6 + lvl7 + lvl8 + lvl9 + lvl10 + lvl11 + lvl12 == 12)
		{
			check.SetActive( true );
			Lock.SetActive( false );
			buttonPlay.SetActive( true );
		}
	}
}
