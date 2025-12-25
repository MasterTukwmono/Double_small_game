using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoldKey : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Target")
        {
            if(!Input.GetKey(KeyCode.S))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
