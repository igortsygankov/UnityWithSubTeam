//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   public Rigidbody rb;
   public float forwardForce = 900f;
   public float sideForce = 600f;

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        // Forward Force
        if(Input.GetKey("g")){
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }

        // Backward Force
        if(Input.GetKey("h")){
            rb.AddForce(0,0,-forwardForce * Time.deltaTime);
        }

        // Move Left
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce * Time.deltaTime,0,0);
        }

        // Move Right
        if(Input.GetKey("d")){
            rb.AddForce(sideForce * Time.deltaTime,0,0);
        }
    }
}
