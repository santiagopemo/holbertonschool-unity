using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookArround : MonoBehaviour
{
    private float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Cursor.visible)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(transform.position, Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, -transform.right, speed * Input.GetAxis("Mouse Y"));
        }
        if (Input.GetMouseButtonUp(1) && Cursor.visible == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
