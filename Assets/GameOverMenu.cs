using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverMenu : MonoBehaviour
{
    void OnLevelWasLoaded(int level)
    {
        Cursor.visible = true;
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
