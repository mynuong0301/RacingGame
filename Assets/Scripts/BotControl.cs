using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class BotControl : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject carBot;
    public AudioSource wheelFX1;
    public AudioSource wheelFX2;
    public AudioSource wheelFX3;
    public AudioSource wheelFX4;

    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints.None;
        wheelFX1.enabled = true;
        wheelFX2.enabled = true;
        wheelFX3.enabled = true;
        wheelFX4.enabled = true;
        carBot.GetComponent<CarController>().MaxSpeed = 100f;
    }

}
