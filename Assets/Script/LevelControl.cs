using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance = null;
    int sceneIndex;
    int levelComplete;



    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void isEndGame()
    {
        if (sceneIndex == 15)
        {
            Invoke("LoadMainMenu", 1f);

        }
        else
        {
            if (levelComplete < sceneIndex)
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            Invoke("NextLevel", 1f);
        }
    }


	public void NextLevel1()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

	public void LoadMainMenu()
    {
        SceneManager.LoadScene("Levels");
    }



}
