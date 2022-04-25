using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    //1=Red, 2=Blue
    public GameObject PinkBody;
    public GameObject RedBody;
    public GameObject DefaultCar;
    public GameObject YellowSPCar;
    public int CarImport;

    // Start is called before the first frame update
    void Start()
    {
        CarImport = SelectionButtonOptions.CarType;

        switch (CarImport)
        {
            case 1: PinkBody.SetActive(true);
                RedBody.SetActive(false);
                break;
            case 2: RedBody.SetActive(true);
                PinkBody.SetActive(false);
                break;
            case 3:
                DefaultCar.SetActive(false);
                YellowSPCar.SetActive(true);
                break;
        }
            
    }

    
}
