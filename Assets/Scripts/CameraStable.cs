using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    public GameObject TheCar;
    float carX, carY, carZ;

    // Update is called once per frame
    void Update()
    {
        carX = TheCar.transform.eulerAngles.x;
        carY = TheCar.transform.eulerAngles.y;
        carZ = TheCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(0, carY, 0);
    }
}
