using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveComplite : MonoBehaviour
{
	public string number;
	private int complite;
	public GameObject check;
    void Update()
	{
		complite = PlayerPrefs.GetInt(number);
		if(complite == 1)
		{
			check.SetActive( true );
		}
	}
}
