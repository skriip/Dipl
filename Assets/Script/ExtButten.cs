using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExtButten : MonoBehaviour
{
	public void ExitSettings()
	{
		SceneManager.LoadScene("Menu");
	}
}
