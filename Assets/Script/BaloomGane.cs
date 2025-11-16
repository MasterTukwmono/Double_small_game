using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BaloomGane : MonoBehaviour
{
    private float Main_speed = 60f;
    private float Nomal_speed = 180f;
    public Scale scale;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.localScale.x >= 0f && transform.localScale.y >= 0f &&
            transform.localScale.z >= 0f)
        {
            transform.localScale -= new Vector3(Main_speed*Time.deltaTime, Main_speed*Time.deltaTime, Main_speed*Time.deltaTime);
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }


        if (transform.localScale.x <= 250f && transform.localScale.y <= 250f &&
            transform.localScale.z <= 250f)
        {
            if (Input.GetKey(KeyCode.I))
            {
                transform.localScale += new Vector3(Nomal_speed*Time.deltaTime, Nomal_speed*Time.deltaTime, Nomal_speed*Time.deltaTime);
            }
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
       
    }
}
