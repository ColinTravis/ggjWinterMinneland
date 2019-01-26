﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float moveSpeed;
    private Rigidbody myRigidbody; // interacts with the Rigidbody movement system
    
    private Vector3 moveInput;
    private Vector3 moveVelocity;

    private Camera mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame (generated by PC)
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVelocity = moveInput * moveSpeed;

    //Point Character At Mouse Location
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayLength; //value for this will be how far the camera is from the ground

        if (groundPlane.Raycast(cameraRay, out rayLength)) //sets however far the camera is from the ground based off of 
        {
            
        }
    }

    
    // Update is always performed at the same time
    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
}
