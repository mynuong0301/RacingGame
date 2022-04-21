using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBtn : MonoBehaviour
{
    private int sceneIndex = 2;

    public void MapSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void Settings()
    {

    }

    public void Credits()
    {
        SceneManager.LoadScene(4);
    }
}
