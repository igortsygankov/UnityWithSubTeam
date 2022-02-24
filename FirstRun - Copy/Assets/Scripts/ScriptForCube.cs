using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptForCube : MonoBehaviour
{
    Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(Vector3.up * 500);
        }
    }
}
