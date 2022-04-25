using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreMode.currentScore += 100;
        }
        else
            ScoreMode.botCurrentScore += 100;
        gameObject.SetActive(false);
    }
}
