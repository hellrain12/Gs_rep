using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_eternal : MonoBehaviour
{
	public GameObject DeathPanel;
	private void OnCollisionEnter2D( Collision2D collision )
	{
		if ( collision.gameObject.tag == "Death" )
		{
			DeathPanel.SetActive( true );
			Time.timeScale = 0f;
		}

	
	}
	private void OnTriggerEnter2D( Collider2D collision )
	{
		if ( collision.gameObject.tag == "Coin" )
		{
			collision.gameObject.GetComponent<Coin>().TakeCoin();
		}
		if ( collision.gameObject.tag == "Gift" )
		{
			collision.gameObject.GetComponent<Gift>().TakeGift();
		}
	}
}
