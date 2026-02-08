
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffle_Game : MonoBehaviour
{
    public int right_Game;
    public GameObject right_camera;
    public int left_Game;
    public GameObject left_camera;

    public GameObject Baloom_Game;
    public GameObject otimono_Game;
    public GameObject Rapid_Game;
    public GameObject Bar_Game;
    void Awake()
    {
        Baloom_Game.SetActive(false);
        otimono_Game.SetActive(false);
        Rapid_Game.SetActive(false);
        Bar_Game.SetActive(false);
    }
    public void shuffle()
    {
        Baloom_Game.SetActive(false);
        otimono_Game.SetActive(false);
        Rapid_Game.SetActive(false);
        Bar_Game.SetActive(false);

        right_Game = Random.Range(1, 5);
        left_Game = Random.Range(1, 5);

        if (right_Game == left_Game)
        {
            shuffle();
        }
        else
        {
            if (right_Game == 1)
            {
                Rapid_Game.SetActive(true);
                right_camera.transform.position = new Vector3(-141, 31, -154);
            }
            else if (right_Game == 2)
            {
                Bar_Game.SetActive(true);
                right_camera.transform.position = new Vector3(-1853, 31, -154);
            }
            else if (right_Game == 3)
            {
                Baloom_Game.SetActive(true);
                right_camera.transform.position = new Vector3(1210, 1039, -1124);
            }
            else if (right_Game == 4)
            {
                otimono_Game.SetActive(true);
                right_camera.transform.position = new Vector3(-755, 474, -1971);
            }

            if (left_Game == 1)
            {
                Rapid_Game.SetActive(true);
                left_camera.transform.position = new Vector3(-141, 31, -154);
            }
            else if (left_Game == 2)
            {
                Bar_Game.SetActive(true);
                left_camera.transform.position = new Vector3(-1853, 31, -154);
            }
            else if (left_Game == 3)
            {
                Baloom_Game.SetActive(true);
                left_camera.transform.position = new Vector3(1210, 1039, -1124);
            }
            else if (left_Game == 4)
            {
                otimono_Game.SetActive(true);
                left_camera.transform.position = new Vector3(-755, 474, -1971);
            }
        }
    }

    float Game_cup = 0f;
    float GameTimer = 0f;

    void Start()
    {
        shuffle();
        Game_cup = Random.Range(7, 18);
    }

    void Update()
    {
        GameTimer += Time.deltaTime;

        if (GameTimer >= Game_cup)
        {
            Start();
            GameTimer = 0f;
        }

    }
}
