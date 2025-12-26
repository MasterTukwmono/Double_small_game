using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rapid_hits : MonoBehaviour
{
    public GameObject wObject;
    public GameObject aObject;
    public GameObject sObject;
    public GameObject dObject;
    private GameObject[] objects;


    private KeyCode[] keys = { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
    private KeyCode currentKey;
    private float OUTtimer = 0f;
    private float KeyTime = 0f;
    private float coolTime = 0f;
    private float Key_cup = 0f;
    void Start()
    {
        objects = new GameObject[] { wObject, aObject, sObject, dObject };
        PickNewKey();
        Key_cup = Random.Range(3, 21); 
    }

    void Update()
    {
        OUTtimer += Time.deltaTime;
        KeyTime += Time.deltaTime;
        coolTime += Time.deltaTime;

        if (coolTime >= 2f)
        {
            if (OUTtimer >= 0.40f)
            {
                //ゲームオーバー画面へ
                Debug.Log("out");
                OUTtimer = 0f;
                SceneManager.LoadScene("GameOver");
            }
        }
 
        if (KeyTime >= Key_cup)
        {
            PickNewKey();
            KeyTime = 0f;
            coolTime = 0f;
            Key_cup = Random.Range(2, 11); 
        }

        if (Input.GetKeyDown(currentKey))
        {
            OUTtimer = 0f;
        }
    }
    
    void PickNewKey()
    {
        // 任意のキーからランダムに選ぶ（W,A,S,D）
        int index = Random.Range(0, keys.Length);
        currentKey = keys[index];
        Debug.Log("Press key: " + currentKey);

        // 対応するオブジェクトだけを有効化、それ以外は無効化
        for (int i = 0; i < objects.Length; i++)
        {
            objects[i].SetActive(i == index);
        }
    }
}


