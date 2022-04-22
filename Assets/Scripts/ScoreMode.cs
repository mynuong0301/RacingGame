using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMode : MonoBehaviour
{
    public int selectedMode;
    public GameObject TimeUI;
    public GameObject ScoreUI;
    public GameObject carBot;
    public static int currentScore;
    public int internalScore;
    public GameObject scoreDisplay;
    public GameObject scoreObjects;

    // Start is called before the first frame update
    void Start()
    {
        selectedMode = SelectionButtonOptions.RaceMode;

        if (selectedMode == 1)
        {
            TimeUI.SetActive(false);
            ScoreUI.SetActive(true);
            carBot.SetActive(false);
            scoreObjects.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        internalScore = currentScore;
        scoreDisplay.GetComponent<Text>().text = "" + internalScore;
    }
}
