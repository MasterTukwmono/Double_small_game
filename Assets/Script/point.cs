using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class point : MonoBehaviour
{
    public static float Score = 0;
    public float Timer = 0;
    public Text Score_Text;
    void Start()
    {
        
    }

    void Update()
    {
        int index = SceneManager.GetActiveScene().buildIndex;

        Score_Text.text = Score.ToString();
        Timer += Time.deltaTime;
        if (index == 1)
        {
            Timer += Time.deltaTime;
            Score += Timer;
        }
    }
}
