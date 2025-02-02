using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
	private saveCompliteLvl save_script;
	private void Update()
	{
		save_script = GameObject.FindGameObjectWithTag( "SaveManager" ).GetComponent<saveCompliteLvl>();
	}
	private void OnTriggerEnter2D( Collider2D collision )
	{
		if ( collision.gameObject.tag == "F" )
		{
			//save_script.saveName = (SceneManager.GetActiveScene().buildIndex - 5).ToString();
			PlayerPrefs.SetInt( (SceneManager.GetActiveScene().buildIndex - 5).ToString(), 1 );
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex +1);
		}
		if ( collision.gameObject.tag == "F2" )
		{
			PlayerPrefs.SetInt( (SceneManager.GetActiveScene().buildIndex - 5).ToString(), 1 );
			SceneManager.LoadScene(0);
		}
	}
	private void OnCollisionEnter2D( Collision2D collision )
	{
		if ( collision.gameObject.tag == "Death" )
		{
			SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
		}

		if ( collision.gameObject.tag == "Phys" )
		{
			collision.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
		}
	}
}
