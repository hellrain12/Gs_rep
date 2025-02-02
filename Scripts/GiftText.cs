using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftText : MonoBehaviour
{
	public Text gift_txt;

    void Update()
    {
        gift_txt.text = "" + PlayerPrefs.GetInt( "gift" ).ToString();
	}
}
