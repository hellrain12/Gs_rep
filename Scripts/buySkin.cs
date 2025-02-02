using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buySkin : MonoBehaviour
{
	public string name;
	public int price;
	private int coin;
	public int skinNumber;
	public GameObject destroy_obj;
	public GameObject setSkin;
	public nextButtonSystem next_script;

	private void Update()
	{
		if(next_script.skinNumberNow != skinNumber)
		{
			this.gameObject.SetActive( false );
		}
		if(this.gameObject.tag != "standartSkin")
		{
			coin = PlayerPrefs.GetInt( "coin" );
			if ( PlayerPrefs.GetInt( name ) == 1 )
			{
				Destroy( destroy_obj.gameObject );
				setSkin.SetActive( true );
			}
		}

	}
	public void Buy()
	{
		Debug.Log( "Кнопка работает" );
		if( coin >= price)
		{
			PlayerPrefs.SetInt( "coin", coin - price );
			PlayerPrefs.SetInt( name, 1 );
			setSkin.SetActive( true );
			Destroy( destroy_obj.gameObject );
		}
		else
		{
			//Debug.LogError( "Не работает код!!!" );
		}
	}
}
