using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unlockable : MonoBehaviour
{
    public GameObject buySPCarBtn;
    public GameObject sportCarButton;
    public GameObject AskPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalCash.totalCash >= 100)
        {
            buySPCarBtn.GetComponent<Button>().interactable = true;
        }
    }

    public void SportCarUnlock()
    {
        buySPCarBtn.SetActive(false);
        GlobalCash.ChangeCash(-100);
        AskPanel.SetActive(false);
        sportCarButton.GetComponent<Button>().interactable = true;
        PlayerPrefs.SetInt("YellowSPCarBought", 100);
    }

    public void ClickBuy()
    {
        AskPanel.SetActive(!AskPanel.activeInHierarchy);
    }
}
