using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    private bool mouseDown = false;
    public bool isInverted;
    private Transform parentTransform;
    private Vector3 localRotation;
    private float mouseSensitivity = 30f;
    public float orbitDampening = 15f;
    private bool lookTrigger = false;

    public InputActionReference mouseXAction;
    public InputActionReference mouseYAction;
    public InputActionReference mouseTrigger;

    void OnEnable()
    {
        mouseXAction.action.Enable();
        mouseYAction.action.Enable();
        mouseTrigger.action.Enable();
    }

    void OnDisable()
    {
        mouseXAction.action.Disable();
        mouseYAction.action.Disable();
        mouseTrigger.action.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        if (PlayerPrefs.HasKey("InvertYToggle"))
            isInverted = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
        else
            isInverted = false;
        if (PlayerPrefs.HasKey("LookSensitivity"))
            mouseSensitivity = PlayerPrefs.GetFloat("LookSensitivity");
        if (PlayerPrefs.HasKey("LookTrigger"))
            lookTrigger = PlayerPrefs.GetInt("LookTrigger") == 0 ? false : true;
        parentTransform = transform.parent;
        // Set Initials conditions if there are wrong in editor
        parentTransform.position = player.transform.position;
        transform.position = new Vector3(0f, 2.5f, -6.25f);
        transform.rotation = Quaternion.Euler(9, 0, 0);

        mouseTrigger.action.started += _ => { mouseDown = true; };
        mouseTrigger.action.canceled += _ => { mouseDown = false; };
    }

    void LateUpdate()
    {
        parentTransform.position = player.transform.position;
        // if (mouseTrigger.action.triggered)
        //     mouseDown = true;
        // else 
        //     mouseDown = false;
        float horizontal = mouseXAction.action.ReadValue<float>() * Time.deltaTime;
        float vertical = mouseYAction.action.ReadValue<float>() * Time.deltaTime;
        // mouseDown = true;
        if (mouseDown || !lookTrigger)
        {
            if (horizontal != 0 || vertical != 0)
            {
                localRotation.x += horizontal * mouseSensitivity;
                if (isInverted)
                    localRotation.y -= vertical * mouseSensitivity;
                else
                    localRotation.y += vertical * mouseSensitivity;
                localRotation.y = Mathf.Clamp(localRotation.y, -60, 80);
            }
        }
        Quaternion QT = Quaternion.Euler(localRotation.y, localRotation.x, 0);
        parentTransform.rotation = Quaternion.Lerp(parentTransform.rotation, QT, orbitDampening); 
    }
}
