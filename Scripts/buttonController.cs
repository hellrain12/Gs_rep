using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{
	public Rigidbody2D rigidbody;
	private int i;
	public void Attack()
	{
		i++;
		
	}
	private void Update()
	{
		if ( i >= 3 )
		{
			i = 0;
			this.gameObject.SetActive( false );
		}
	}
}
