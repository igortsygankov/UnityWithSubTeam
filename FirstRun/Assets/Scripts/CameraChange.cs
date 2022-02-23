using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject FirstPersonCamera;
    public GameObject ThirdPersonCamera;
    public GameObject TopViewCamera;

    void Update()
    {
        if (Input.GetButtonDown("Camera3"))
        {
            if (ThirdPersonCamera.activeSelf)
            {
                FirstPersonCamera.SetActive(true);
                ThirdPersonCamera.SetActive(false);
                TopViewCamera.SetActive(false);
            }

            else
            {
                FirstPersonCamera.SetActive(false);
                ThirdPersonCamera.SetActive(true);
                TopViewCamera.SetActive(false);
            }
        }

        if (Input.GetButtonDown("CameraTop"))
        {
            if (TopViewCamera.activeSelf)
            {
                FirstPersonCamera.SetActive(true);
                ThirdPersonCamera.SetActive(false);
                TopViewCamera.SetActive(false);
            }

            else
            {
                FirstPersonCamera.SetActive(false);
                ThirdPersonCamera.SetActive(false);
                TopViewCamera.SetActive(true);
            }
        }
    }  
}
