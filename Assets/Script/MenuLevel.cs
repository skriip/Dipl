using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuLevel : MonoBehaviour
{
	public Button level1;
	public Button level2;
	public Button level3;
    public Button level4;
	public Button level5;
	public Button level6;
    public Button level7;
	public Button level8;
	public Button level9;
    public Button level10;
	public Button level11;
	public Button level12;
    public Button level13;
	public Button level14;
	public Button level15;
    public Button NextButten;
    
	int levelComplete;

	// Start is called before the first frame update
	void Start()
    {
		levelComplete = PlayerPrefs.GetInt("LevelComplete");
		level2.interactable = false;
		level3.interactable = false;
		level4.interactable = false;
		level5.interactable = false;
		level6.interactable = false;
		level7.interactable = false;
		level8.interactable = false;
		level9.interactable = false;
		level10.interactable = false;
		level11.interactable = false;
		level12.interactable = false;
		level13.interactable = false;
		level14.interactable = false;
		level15.interactable = false;
		


		switch(levelComplete)
		{
			case 1:
				level2.interactable = true;
				break;
				case 2:
				level2.interactable = true;
				level3.interactable = true;
				break;
				case 3:
				level3.interactable = true;
				level4.interactable = true;
				break;
				case 4:
				level4.interactable = true;
				level5.interactable = true;
				break;
				case 5:
				level5.interactable = true;
				level6.interactable = true;
				break;
				case 6:
				level6.interactable = true;
				level7.interactable = true;
				break;
				case 7:
				level7.interactable = true;
				level8.interactable = true;
				break;
				case 8:
				level8.interactable = true;
				level9.interactable = true;
				break;
				case 9:
				level9.interactable = true;
				level10.interactable = true;
				break;
				case 10:
				level10.interactable = true;
				level11.interactable = true;
				break ;
				case 11:
				level11.interactable = true;
				level12.interactable = true;
				break;
				case 12:
				level12.interactable = true;
				level13.interactable = true;
				break;
				case 13:
				level13.interactable = true;
				level14.interactable = true;
				break;
				case 14:
				level14.interactable = true;
				level15.interactable = true;
				break;

		}
	}
	public void LoadTo(int level)
	{
		SceneManager.LoadScene(level);
	}
	
    
}
