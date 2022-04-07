using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject finishTrig;
    public GameObject pointTrig;

    private void OnTriggerEnter(Collider other)
    {
        finishTrig.SetActive(true);
        pointTrig.SetActive(false);
    }
}
