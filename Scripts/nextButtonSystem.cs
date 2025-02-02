using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextButtonSystem : MonoBehaviour
{
	public int skinNumberNow;
	public GameObject[] all_skins;
	public int max_skins;

	private void Start()
	{
		skinNumberNow = PlayerPrefs.GetInt( "SetSkin");
	}

	public void Next()
	{
		skinNumberNow += 1;
		if ( skinNumberNow > max_skins - 1 )
		{
			skinNumberNow = 0;
			all_skins[0].SetActive( true );
		}
		if ( skinNumberNow <= max_skins - 1 )
		{
			all_skins[skinNumberNow].SetActive( true );
		}

	}

	public void UnNext()
	{
		skinNumberNow -= 1;
		if ( skinNumberNow < 0 )
		{
			skinNumberNow = max_skins - 1;
			all_skins[max_skins - 1].SetActive( true );
		}
		if ( skinNumberNow <= max_skins - 1 )
		{
			all_skins[skinNumberNow].SetActive( true );
		}

	}
	public void SetSkin()
	{
		PlayerPrefs.SetInt( "SetSkin", skinNumberNow );
	}
    void Update()
    {
		
	}
}
