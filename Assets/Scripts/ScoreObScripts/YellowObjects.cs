using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowObjects : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        ScoreMode.currentScore += 25;
        gameObject.SetActive(false);
    }
}
