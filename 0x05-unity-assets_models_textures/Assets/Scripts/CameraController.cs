using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    private GameObject player;
    public float rotationSpeed = 10.0f;

    float xRotation = 0;
    float yRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        yRotation -= Input.GetAxis("Mouse Y") * rotationSpeed;
        xRotation += Input.GetAxis("Mouse X") * rotationSpeed;
        transform.eulerAngles = new Vector3(yRotation, xRotation, 0) ;
        transform.position = player.transform.position + offset;
    }
}
