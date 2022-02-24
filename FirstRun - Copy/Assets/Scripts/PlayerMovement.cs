using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Player;
    public float movementSpeed, rotateSpeed;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) Player.velocity = transform.forward * movementSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S)) Player.velocity = -transform.forward * movementSpeed * Time.deltaTime;

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.D)) transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Space)) Player.AddForce(Vector3.up * movementSpeed * 3);
    }



    /*public Rigidbody Player;
    public float speed, rotatationSpeed;

    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizonalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizonalInput, 0, verticalInput);
        float magnitude = Mathf.Clamp01(movementDirection.magnitude) * speed;
        movementDirection.Normalize();

        characterController.SimpleMove(movementDirection * magnitude);

        if(movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotatationSpeed * Time.deltaTime);
        }
    }*/

}



