using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour
{
	public static int gifts;
	private void Start()
	{
		gifts = PlayerPrefs.GetInt( "gift" );
	}
	public void TakeGift()
	{
		gifts = PlayerPrefs.GetInt( "gift" );
		gifts++;
		PlayerPrefs.SetInt( "gift", gifts );
		Destroy( this.gameObject );
	}
}
