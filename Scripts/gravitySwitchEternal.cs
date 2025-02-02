using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitySwitchEternal : MonoBehaviour
{
	public Rigidbody2D rigidbody;
	private bool switchGravity;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.gravityScale = 1.7f;
	}

	void Update()
	{
		if ( Input.GetKeyDown( KeyCode.Space ) )
		{
			switchGravity = !switchGravity;
		}

		if ( switchGravity == false )
		{
			rigidbody.gravityScale = 1.7f;
		}

		if ( switchGravity == true )
		{
			rigidbody.gravityScale = -1.7f;
		}
	}

	public void Touch()
	{
		switchGravity = !switchGravity;
	}
}
