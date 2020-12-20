using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public string Level1;
	public string Level2;
	public string Level3;
	public string Level4;
	public string Level5;
	public string Level6;
	public string Level7;
	public string Level8;
	public string Level9;

	public void StartLevel1() 
	{
		SceneManager.LoadScene(Level1);
	}

	public void StartLevel2() 
	{
		SceneManager.LoadScene(Level2);
	}

	public void StartLevel3() 
	{
		SceneManager.LoadScene(Level3);
	}

	public void StartLevel4() 
	{
		SceneManager.LoadScene(Level4);
	}

	public void StartLevel5() 
	{
		SceneManager.LoadScene(Level5);
	}

	public void StartLevel6() 
	{
		SceneManager.LoadScene(Level6);
	}

	public void StartLevel7() 
	{
		SceneManager.LoadScene(Level7);
	}

	public void StartLevel8() 
	{
		SceneManager.LoadScene(Level8);
	}

	public void StartLevel9() 
	{
		SceneManager.LoadScene(Level9);
	}
		
	public void QuitGame() 
	{
		Application.Quit();
	}

}
