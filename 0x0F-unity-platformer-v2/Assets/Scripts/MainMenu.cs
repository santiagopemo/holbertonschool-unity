﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public Button[] buttons;

    [Header("Buttons Sounds")]
    public AudioSource buttonRollover;
    public AudioSource buttonClick;

    // EventSystem eventSystem;
    // private GameObject currentSelectedButton;
    // private GameObject lastSelectedButton;


    // void OnEnable()
    // {
    //     eventSystem = EventSystem.current;
    //     currentSelectedButton = eventSystem.currentSelectedGameObject;
    // }

    void Start()
    {
        AddButtonsTriggers();
    }

    // Start is called before the first frame update
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    void AddButtonsTriggers()
    {
        buttons = transform.GetComponentsInChildren<Button>();
        for (int i = 0; i < buttons.Length; i++)
        {
            EventTrigger btnETrigger = buttons[i].gameObject.AddComponent<EventTrigger>();
            // Adding Hover Trigger
            EventTrigger.Entry hoverEntry = new EventTrigger.Entry();
            hoverEntry.eventID = EventTriggerType.PointerEnter;
            hoverEntry.callback.AddListener((data) => {OnButtonHover();});
            btnETrigger.triggers.Add(hoverEntry);
            // Adding Click Trigger
            EventTrigger.Entry clickEntry = new EventTrigger.Entry();
            clickEntry.eventID = EventTriggerType.PointerDown;
            clickEntry.callback.AddListener((data) => {OnButtonClick();});
            btnETrigger.triggers.Add(clickEntry);
            // Adding Submit Trigger
            EventTrigger.Entry submitEntry = new EventTrigger.Entry();
            submitEntry.eventID = EventTriggerType.Submit;
            submitEntry.callback.AddListener((data) => {OnButtonClick();});
            btnETrigger.triggers.Add(submitEntry);             
        }
    }

    public void OnButtonHover()
    {
        buttonRollover.Play();
    }

    public void OnButtonClick()
    {
        buttonClick.Play();
    }

    public void OptionsButton()
    {
        PlayerPrefs.SetString("previous-scene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }

    public void ExitButton()
    {
        Debug.Log("Exited");
        Application.Quit();
    }


    // void Update()
    // {
    //     if (eventSystem.currentSelectedGameObject != currentSelectedButton)
    //     {
    //         print("cambie!!");
    //         buttonRollover.Play();
    //         currentSelectedButton = eventSystem.currentSelectedGameObject;
    //     }
    // }
}
