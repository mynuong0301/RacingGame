using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCast : MonoBehaviour
{
    public int castValue;
    public static int totalCast;
    public GameObject castDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        castValue = totalCast;
        castDisplay.GetComponent<Text>().text = "" + castValue;
    }
}
