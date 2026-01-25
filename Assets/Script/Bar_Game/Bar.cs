using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private float Speed = 300.0f;
    public bool overTarget = false;

    public GameObject holdkey;
    public HoldKey HK;
    

    private void Start()
    {
        holdkey = GameObject.Find("Target");
        HK = holdkey.GetComponent<HoldKey>();
    }

    private void Update()
    {
      transform.position += transform.right *Speed *Time.deltaTime;
      if(HK.CanHold == true)
        {
           if(Input.GetKeyDown(KeyCode.S))
            {
                Renderer renderer = GetComponent<Renderer>();
                Color c = renderer.material.color; // もともとの色を取得
                c.a = 50f;                           // 透明度だけ変更
                renderer.material.color = c;

            } 
        }
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
