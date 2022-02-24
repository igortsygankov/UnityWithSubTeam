using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Jump()
    {
        animator.SetTrigger("PlayerJump");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
