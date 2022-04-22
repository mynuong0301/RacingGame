using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObjects : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        ScoreMode.currentScore += 100;
        gameObject.SetActive(false);
    }
}
