using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WillGnereter : MonoBehaviour
{
    public GameObject Walls;

    float timer = 0;
    int interval = 2;

    void Start()
    {
             
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            transform.position = new Vector3(Random.Range(-1000, -500), transform.position.y, transform.position.z);
            Instantiate(Walls , transform.position, transform.rotation);
            timer = 0f;
        }
            
    }
}
