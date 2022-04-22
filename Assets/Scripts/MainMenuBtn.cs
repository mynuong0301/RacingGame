using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBtn : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;

    public void MapSelect()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void Settings()
    {
        MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

    //Settings panel
    public void MainMenu()
    {
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
