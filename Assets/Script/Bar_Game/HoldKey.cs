using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoldKey : MonoBehaviour
{
    private bool CanHold = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
            {
                CanHold = true;
            }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Target")
        {
            if(CanHold == false)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            if(!Input.GetKey(KeyCode.S))
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Target")
        {
            CanHold = false;
        }
    }

    
}
