using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class settingsManager : MonoBehaviour
{

	public PostProcessProfile postProfile;
	public GameObject onPost;
	public GameObject offPost;
	public static int setPosting = 1;

	private void Start()
	{
		PlayerPrefs.GetInt( "set" );
		setPosting= PlayerPrefs.GetInt( "set" );
	}
	private void Update()
	{
		if( postProfile.GetSetting<Bloom>().active == false || setPosting == 0)
		{
			postProfile.GetSetting<Bloom>().active = false;
			onPost.SetActive( false );
			offPost.SetActive( true );
		}

		if ( postProfile.GetSetting<Bloom>().active == true || setPosting == 1 )
		{
			postProfile.GetSetting<Bloom>().active = true;
			onPost.SetActive( true );
			offPost.SetActive( false );
		}
	}

	public void setPost()
	{
		postProfile.GetSetting<Bloom>().active = false;
		onPost.SetActive(false);
		offPost.SetActive(true);
		setPosting = 0;
		PlayerPrefs.SetInt( "set", setPosting );
	}

	public void setPost2()
	{
		postProfile.GetSetting<Bloom>().active = true;
		onPost.SetActive(true);
		offPost.SetActive(false);
		setPosting = 1;
		PlayerPrefs.SetInt( "set", setPosting );
	}
}
