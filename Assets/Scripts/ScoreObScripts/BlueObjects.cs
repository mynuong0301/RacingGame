using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueObjects : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        ScoreMode.currentScore += 50;
        gameObject.SetActive(false);
    }
}
