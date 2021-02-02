using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector3 offset;
    private GameObject player;
    public float turnSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.left) * offset;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
    }
}
