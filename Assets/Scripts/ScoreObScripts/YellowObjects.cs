using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowObjects : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ScoreMode.currentScore += 25;
        }
        else
            //if (collision.gameObject.tag == "Car_Bot")
            ScoreMode.botCurrentScore += 25;
        gameObject.SetActive(false);
    }
}
