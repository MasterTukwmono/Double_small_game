using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject Rules;

    void Start()
    {
        Rules.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            point.Score = 0;
            SceneManager.LoadScene("Main");
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            Rules.SetActive(false);
        }
    }

    public void OnButton()
    {
        Rules.SetActive(true);
    }
}
