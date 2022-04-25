using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuBtn : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;
    public GameObject MainMenuBtns;
    public GameObject RandomPanel, RanDomMap, RanDomMode;

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

    public void RanDom()
    {
        int map = Random.Range(2, 3);
        int carType = Random.Range(1, 3);
        int raceMode = Random.Range(1, 2);
        SelectionButtonOptions.CarType = carType;
        SelectionButtonOptions.RaceMode = raceMode;
        Debug.Log("Map:" + map + " mode:" + raceMode);
        MainMenuBtns.SetActive(false);
        RandomPanel.SetActive(true);

        if (raceMode == 1)
            RanDomMode.GetComponent<Text>().text = "Starting Score mode ";
        else
            RanDomMode.GetComponent<Text>().text = "Starting Time mode ";

        if (map == 2)
            RanDomMap.GetComponent<Text>().text = " - Map Foresh";
        else
            RanDomMap.GetComponent<Text>().text = " - Map Moon Mountain";

        SceneManager.LoadScene(map);
    }

    

    //Settings panel
    public void MainMenu()
    {
        MainMenuPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
}
