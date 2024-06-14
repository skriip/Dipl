using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelControl.instance.isEndGame();
    }

}
