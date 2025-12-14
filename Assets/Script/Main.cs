using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            point.Score = 0;
            SceneManager.LoadScene("Main");
        }
    }
}
