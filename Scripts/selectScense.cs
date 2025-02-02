using UnityEngine;
using UnityEngine.SceneManagement;

public class selectScense : MonoBehaviour
{
	public static int x;

	//Вписать номер первого уровня из списка сцен
	[SerializeField]private int sceneStart; 
	
	public GameObject panel;

	public void Menu()
	{
		SceneManager.LoadScene(0);
		Time.timeScale = 1f;
	}
	public void MenuSettings()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(x);
	}
	public void restart()
	{
		SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
		Time.timeScale = 1f;
	}
	public void Settings()
	{
		x = 0;
		SceneManager.LoadScene(1);
	}
	public void Settings2()
	{
		SceneManager.LoadScene(1);
		x = SceneManager.GetActiveScene().buildIndex;
	}
	public void Levles()
	{
		SceneManager.LoadScene( 2 );
	}
	public void Eternal()
	{
		SceneManager.LoadScene( 5 );
	}
	public void ShopScene()
	{
		SceneManager.LoadScene( 18 );
	}
	public void Event()
	{
		SceneManager.LoadScene( 19 );
	}
	public void Eternal_event()
	{
		SceneManager.LoadScene( 20 );
	}
	public void SelectScene()
	{
		SceneManager.LoadScene( 3 );
	}
	public void proCompany()
	{
		SceneManager.LoadScene( 4 );
	}
	public void lvl1()
	{
		SceneManager.LoadScene( sceneStart );
	}
	public void lvl2()
	{
		SceneManager.LoadScene( sceneStart += 1);
	}
	public void lvl3()
	{
		SceneManager.LoadScene( sceneStart += 2);
	}
	public void lvl4()
	{
		SceneManager.LoadScene( sceneStart += 3 );
	}
	public void lvl5()
	{
		SceneManager.LoadScene( sceneStart += 4 );
	}
	public void lvl6()
	{
		SceneManager.LoadScene( sceneStart += 5 );
	}
	public void lvl7()
	{
		SceneManager.LoadScene( sceneStart += 6 );
	}
	public void lvl8()
	{
		SceneManager.LoadScene( sceneStart += 7 );
	}
	public void lvl9()
	{
		SceneManager.LoadScene( sceneStart += 8);
	}
	public void lvl10()
	{
		SceneManager.LoadScene( sceneStart += 9 );
	}
	public void lvl11()
	{
		SceneManager.LoadScene( sceneStart += 10 );
	}
	public void lvl12()
	{
		SceneManager.LoadScene( sceneStart += 11 );
	}

	public void account()
	{
		panel.SetActive( true );
	}

	public void account_exit()
	{
		panel.SetActive( false);
	}
}
