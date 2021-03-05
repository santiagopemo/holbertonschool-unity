using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // private List<Action> menuOptions = new List<Action>();
    Action[] menuOptions = new Action[4];
    private int menuItems;
    private int menuIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        menuItems = transform.childCount;
        transform.GetChild(menuIndex).Find("Pointer").GetComponent<Image>().enabled = true;
        menuOptions[0] = OnePlayerMode;
        menuOptions[1] = TwoPlayersMode;
        menuOptions[2] = Leaderboard;
        menuOptions[3] = QuitGame;
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
    void OnePlayerMode()
    {
        PlayerPrefs.SetInt("NumPlayers", 1);
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level01");
    }

    void TwoPlayersMode()
    {
        PlayerPrefs.SetInt("NumPlayers", 2);
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Level01");
    }

    void Leaderboard()
    {
        PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Leaderboard");
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
