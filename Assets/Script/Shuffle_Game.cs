
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle_Game : MonoBehaviour
{
    public int right_Game;
    public GameObject right_camera;
    
    public GameObject Baloom_Game;
    public GameObject otimono_Game;
    void Awake()
    {
        Baloom_Game.SetActive(false);
        otimono_Game.SetActive(false);
    }
    void Start()
    {
        right_Game = Random.Range(1,3);
        Debug.Log(right_Game);

        if(right_Game == 1)
        {
            Baloom_Game.SetActive(true);
            right_camera.transform.position = new Vector3(1210,1039,-1124);
        }
        else if(right_Game == 2)
        {
            otimono_Game.SetActive(true);
            right_camera.transform.position = new Vector3(-755,474,-1971); 
        }
    }

    void Update()
    {
        
    }
}
