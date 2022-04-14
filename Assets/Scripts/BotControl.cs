using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotControl : MonoBehaviour
{
    public Rigidbody rb;
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
    }

}
