using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour
{
	public Text coin_txt;

    void Update()
    {
        coin_txt.text = "" + PlayerPrefs.GetInt( "coin" ).ToString();
	}
}
