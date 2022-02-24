using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayToNight : MonoBehaviour
{
    public GameObject Light;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("MainLight"))
        {
            if (Light.activeSelf)
            {
                Light.SetActive(false);
            }

            else
            {
                Light.SetActive(true);
            }
        }
    }
}
