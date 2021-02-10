﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    public Transform cam;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    private Vector3 initialPosition;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        initialPosition = transform.position;
        initialPosition.y += 20;
    }
    void Update() {
        float xDisplacement = Input.GetAxis("Horizontal");
        float zDisplacement = Input.GetAxis("Vertical");
        
        if (controller.isGrounded) 
        {
            moveDirection = new Vector3(xDisplacement * speed, 0, zDisplacement * speed);
            if (Input.GetKeyDown(KeyCode.Space))
                moveDirection.y = jumpSpeed;          
        }
        else
        {
            moveDirection = new Vector3(xDisplacement * speed, moveDirection.y, zDisplacement * speed);
        }
        moveDirection.y += gravity * Time.deltaTime;
        if (moveDirection.x != 0.0f || moveDirection.z != 0.0f)
        {
            float targetAngle = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            moveDir.y = moveDirection.y;
            moveDir.x *= speed;
            moveDir.z *= speed;
            controller.Move(moveDir * Time.deltaTime);
        }
        else
            controller.Move(moveDirection * Time.deltaTime);

        if (transform.position.y < -30)
            transform.position = initialPosition;
    }
}
