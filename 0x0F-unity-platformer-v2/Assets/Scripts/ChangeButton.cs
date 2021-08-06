using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeButton : MonoBehaviour
{
    EventSystem eventSystem;
    private GameObject currentSelectedButton;
    private GameObject lastSelectedButton;
    public AudioSource buttonRollover;


    void OnEnable()
    {
        eventSystem = EventSystem.current;
        currentSelectedButton = eventSystem.currentSelectedGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (eventSystem.currentSelectedGameObject != currentSelectedButton)
        {
            print("cambie!!");
            buttonRollover.Play();
            currentSelectedButton = eventSystem.currentSelectedGameObject;
        }
    }
}
