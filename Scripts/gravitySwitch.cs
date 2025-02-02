using UnityEngine;

public class gravitySwitch : MonoBehaviour
{
	public Rigidbody2D rigidbody;
	private bool switchGravity;
	public Transform pos;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.gravityScale = 1;
	}

	void Update()
    {
		//Touch touch = Input.GetTouch( 0 );
		//if (touch.phase == TouchPhase.Began)
		//{
		//	switchGravity = !switchGravity;
		//}
		//if ( Input.touchCount > 0 )
		//{
		//	//Touch touch = Input.GetTouch( 0 );
			
		//}

		if ( Input.GetKeyDown(KeyCode.Space) ||  ( Input.GetMouseButtonDown( 2) ))
		{
				switchGravity = !switchGravity;
		}

		if (switchGravity == false)
		{
			rigidbody.gravityScale = 1.5f;
		}

		if ( switchGravity == true)
		{
			rigidbody.gravityScale = -1.5f;
		}
	}

	public void Touch()
	{
		switchGravity = !switchGravity;
	}

	private void OnTriggerEnter2D( Collider2D collision )
	{
		if ( collision.gameObject.tag == "Portal" )
		{
			this.gameObject.transform.position = pos.position;
			switchGravity = !switchGravity;
		}
	}
}
