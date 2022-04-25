using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    public int cashValue;
    public static int totalCash;
    public GameObject cashDisplay;

    // Start is called before the first frame update
    void Start()
    {
        totalCash = PlayerPrefs.GetInt("Cash");
    }

    // Update is called once per frame
    void Update()
    {
        cashValue = totalCash;
        cashDisplay.GetComponent<Text>().text = "" + cashValue;
    }

    public static void ChangeCash(int value)
    {
        totalCash = PlayerPrefs.GetInt("Cash");
        totalCash += value;
        PlayerPrefs.SetInt("Cash", totalCash);
    }
}
