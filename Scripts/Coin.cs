using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
	public static int coins;
	private void Start()
	{
		coins = PlayerPrefs.GetInt( "coin" );
	}
	public void TakeCoin()
	{
		coins = PlayerPrefs.GetInt( "coin" );
		coins++;
		PlayerPrefs.SetInt( "coin", coins );
		Destroy( this.gameObject );
	}
}
