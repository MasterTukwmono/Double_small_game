using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private float Speed = 200.0f;
    public bool overTarget = false;

    private void Update()
    {
      transform.position += transform.right *Speed *Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Target"))
        {
            overTarget = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Target"))
        {
            overTarget = false;
        }
    }
}
