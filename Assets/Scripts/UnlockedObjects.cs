using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockedObjects : MonoBehaviour
{
    public GameObject BuySPCarBtn;
    public GameObject SPCar;

    // Start is called before the first frame update
    void Start()
    {
        int SPCarStatus = PlayerPrefs.GetInt("YellowSPCarBought");

        if (SPCarStatus == 100)
        {
            BuySPCarBtn.SetActive(false);
            SPCar.GetComponent<Button>().interactable = true;
        }
    }

    
}
