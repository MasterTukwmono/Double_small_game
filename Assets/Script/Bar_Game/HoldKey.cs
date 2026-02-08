using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoldKey : MonoBehaviour
{
    public bool CanHold = true;
    public GameObject Barrier;
    private MeshRenderer[] mrs;


    private void Start()
    {
        mrs = Barrier.GetComponentsInChildren<MeshRenderer>();
    }

    void SetBarrierVisible(bool visible)
    {
    foreach (var r in mrs)
        {
            r.enabled = visible;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
            {
                CanHold = true;
            }

        if(Input.GetKey(KeyCode.S))
        {
            if(CanHold == true)
            {
                SetBarrierVisible(true);
            }
            else
            {
                SetBarrierVisible(false);
            }
        }
        else
        {
            SetBarrierVisible(false);
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
