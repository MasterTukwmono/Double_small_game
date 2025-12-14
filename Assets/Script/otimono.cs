using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class otimono : MonoBehaviour
{

    private float speed = 315.0f;
    float delayUntilDestoryed = 10.0f;

    void Start()
    {
        Destroy(gameObject,delayUntilDestoryed);
    }

    void Update()
    {
        transform.position += -transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1hit");
        if(other.gameObject.tag == "player")
        {
            Debug.Log("2hit");
            SceneManager.LoadScene("Gameover");
        }
    }
}
