﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbColision : MonoBehaviour
{
    public PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.FindObjectOfType<PlayerController>().GetComponent<PlayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        controller.isGrounded = true;
    }

}
