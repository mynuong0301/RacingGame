using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionButtonOptions : MonoBehaviour
{
    private static int sceneIndex; //2=Foresh, 3=Night Mountain
    public static int CarType; //1=Pink, 2=Red

    private void Start()
    {
        CarType = 1;
        Car01btn.Select();
        sceneIndex = 2;
    }

    private void Update()
    {
        if (MapSelectPanel.activeInHierarchy && sceneIndex == 2)
            Map01btn.Select();
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
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    //Map selection panel
    public GameObject CarSelectPanel;
    public Button Map01btn;

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

    public void PlayGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
