﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour
{
    Rigidbody rb;
    public int force;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){  //left mouce button
            rb.AddForce(transform.forward * force);
            Debug.Log("it 'thrusted'?");
        }

    }
}
