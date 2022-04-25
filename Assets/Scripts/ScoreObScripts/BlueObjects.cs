using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreMode.currentScore += 50;
        }
        else
            ScoreMode.botCurrentScore += 50;
        gameObject.SetActive(false);
    }
}
