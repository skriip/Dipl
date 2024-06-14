using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TeoNext : MonoBehaviour
{
	public void LoadTo(int level)
	{
		SceneManager.LoadScene(level);
	}
}
