using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}

	public void LoaTo(int level)
	{
		SceneManager.LoadScene(level);
	}


	public void ExitGame()
	{
		Debug.Log("���� ���������");
		Application.Quit();
	}
}
