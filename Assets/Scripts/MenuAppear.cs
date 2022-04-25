using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAppear : MonoBehaviour
{
    public GameObject fullButton;
    public GameObject textClick;
    public GameObject menuButtons;

    public void StartMenu()
    {
        textClick.SetActive(false);
        fullButton.SetActive(false);
        menuButtons.SetActive(true);
    }
}
