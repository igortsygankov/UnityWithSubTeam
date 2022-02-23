using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{
    public bool inRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(inRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("E pressed");
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
       
    }

    private void OnTriggerExit(Collider collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            inRange = false;

        }
    }
}
