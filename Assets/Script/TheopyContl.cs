using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheopyContl : MonoBehaviour
{
	public void LoaTol(int level)
	{
		SceneManager.LoadScene(level);
	}

	public void ExitSettings()
	{
		SceneManager.LoadScene("Menu");
	}

}
