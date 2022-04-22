using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionButtonOptions : MonoBehaviour
{
    private static int sceneIndex; //2=Foresh, 3=Night Mountain
    public static int CarType; //1=Pink, 2=Red
    public static int RaceMode = 1; //1=Score, 2=Time

    private void Start()
    {
        CarType = 1;
        Car01btn.Select();
        sceneIndex = 2;
    }


    //Car selection panel
    public GameObject MapSelectPanel;
    public Button Car01btn;

    public void PinkCar()
    {
        CarType = 1;
    }

    public void RedCar()
    {
        CarType = 2;
    }

    public void NextBtn()
    {
        MapSelectPanel.SetActive(true);
        Map01btn.Select();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Map selection panel
    public GameObject CarSelectPanel;
    public Button Map01btn;
    public GameObject ModeInfoPanel;
    public Button InfoBtn;

    public void BackBtn()
    {
        CarSelectPanel.SetActive(true);
    }
    
    public void Map01()
    {
        sceneIndex = 2;
    }

    public void Map02()
    {
        sceneIndex = 3;
    }

    public void PlayScoreMode()
    {
        RaceMode = 1;
        SceneManager.LoadScene(sceneIndex);
    }

    public void PlayTimeMode()
    {
        RaceMode = 2;
        SceneManager.LoadScene(sceneIndex);
    }

    public void ModeInfo()
    {
        ModeInfoPanel.SetActive(!ModeInfoPanel.activeInHierarchy);
        
    }

    public void OKbtn()
    {
        ModeInfoPanel.SetActive(false);
    }
}
