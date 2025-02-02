using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
	public GameObject PausePanel;
  public void PauseBattonPresent()
	{
		PausePanel.SetActive( true );
		Time.timeScale = 0f;
	}

	public void ContinueBattonPresent()
	{
		PausePanel.SetActive(false);
		Time.timeScale = 1f;
	}
}
