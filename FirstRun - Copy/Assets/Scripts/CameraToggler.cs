using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CameraToggler : MonoBehaviour
{
     
    public GameObject[] Cameras;
     
    int currentCam;
     
    // Start with camera at index 0
    public void Start()
    {
        currentCam = 0;
        setCam(currentCam);
    }
     
     // set currentCam as active and switch other cameras to inactive
    public void setCam(int camIndex){
        for(int i = 0; i < Cameras.Length; i++)
        {
            if(i == camIndex){
                Cameras[i].SetActive(true);
            }
            else
            {
                Cameras[i].SetActive(false);
            }
        }
    }

    // toggle to the next camera on the GameObject[] array or revert to beginning of array
    public void toggleCam(){
        currentCam++;
        if(currentCam > Cameras.Length-1)
            currentCam = 0;
        setCam(currentCam);
    }
     
    // call toggleCam() once "1" key is pressed
    void Update()
    {
        if(Input.GetKey("1")){
            toggleCam();
        }
    }
}