using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{
	public float speed = 0.1f;
	public bool startMove;
	private void Update()
	{
		if (startMove)
        {
			this.transform.position = new Vector2( this.transform.position.x + speed * Time.deltaTime, this.transform.position.y );
		}
		if(this.transform.position.x >= 0)
		{
			startMove = false;
		}
	}
}
