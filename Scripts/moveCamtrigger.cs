using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamtrigger : MonoBehaviour
{
	public Camera cam;
	public Transform spawn;
	public GameObject platform;

	private void OnCollisionEnter2D( Collision2D collision )
	{
		if(collision.gameObject.tag == "player")
		{
			collision.gameObject.transform.position = spawn.transform.position;
			cam.transform.position = new Vector3( 0, -13, -28 );
			platform.GetComponent<movePlatform>().startMove = true;
		}
	}
}
