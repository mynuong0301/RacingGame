using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControl : MonoBehaviour
{
    public GameObject carControl;

    // Start is called before the first frame update
    void Start()
    {
        carControl.GetComponent<CarUserControl>().enabled = true;
    }

    
}
