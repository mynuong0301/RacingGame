using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public GameObject finishTrig;
    public GameObject pointTrig;
    public GameObject CompleteText;

    private void OnTriggerEnter(Collider other)
    {
        finishTrig.SetActive(true);
        pointTrig.SetActive(false);
        CompleteText.SetActive(false);
    }
}
