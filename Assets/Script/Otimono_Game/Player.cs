using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 300.0f;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            if(transform.position.x < -370)
            {
                transform.position += new Vector3(speed*Time.deltaTime,0,0);
            }
        }

        if(Input.GetKey(KeyCode.J))
        {
            if(transform.position.x > -1100)
            {
                transform.position += new Vector3(-speed * Time.deltaTime,0,0);
            }
        }
    }
}
