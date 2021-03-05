using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    Action[] menuOptions = new Action[2];
    private int menuItems;
    private int menuIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        menuItems = transform.childCount;
        transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = true;
        menuOptions[0] = Resume;
        menuOptions[1] = MainMenu;       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = false;
            menuIndex--;
            if (menuIndex < 0)
                menuIndex = menuItems - 1;
            transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = true;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = false;
            menuIndex++;
            if (menuIndex > menuItems - 1)
                menuIndex = 0;
            transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            menuOptions[menuIndex]();
        }        
    }

    void Resume()
    {
        Time.timeScale = 1;
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    void MainMenu()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("MainMenu");
    }
}
