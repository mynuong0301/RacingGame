using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{
    public GameObject posDisplay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CarPos")
        {
            posDisplay.GetComponent<Text>().text = "1st Place!";
        }
    }
}
