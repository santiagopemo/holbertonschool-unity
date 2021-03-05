using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    public Text txtLeaders;
    // Start is called before the first frame update
    void Start()
    {
        string lastScene;
        if (PlayerPrefs.HasKey("LastScene"))
        {
            lastScene = PlayerPrefs.GetString("LastScene");
        }
        else
        {
            lastScene = SceneManager.GetActiveScene().name;
        }
        if (lastScene == "Level01")
        {
            if (PlayerPrefs.GetString("CurrentName") == "")
                SetLeader("NN", PlayerPrefs.GetInt("CurrentScore"));
            else
                SetLeader(PlayerPrefs.GetString("CurrentName"), PlayerPrefs.GetInt("CurrentScore"));
        }
        PrintLeaders();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            PlayerPrefs.SetString("LastScene", SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("MainMenu");
        }
    }
    void SetLeader(string nameToSet, int scoreToSet)
    {
        for (int i = 0; i < 5; i++)
        {
            if (PlayerPrefs.HasKey("Leader" + (i + 1)) && PlayerPrefs.HasKey("Score" + (i + 1)))
            {
                string name = PlayerPrefs.GetString("Leader" + (i + 1));
                int score = PlayerPrefs.GetInt("Score" + (i + 1));
                if (scoreToSet > score)
                {
                    PlayerPrefs.SetString("Leader" + (i + 1), nameToSet);
                    PlayerPrefs.SetInt("Score" + (i + 1), scoreToSet);
                    nameToSet = name;
                    scoreToSet = score;
                }
            }
            else
            {
                PlayerPrefs.SetString("Leader" + (i + 1), nameToSet);
                PlayerPrefs.SetInt("Score" + (i + 1), scoreToSet);
                break;
            }
        }
    }
    void PrintLeaders()
    {
        string leaders = "";
        for (int i = 0; i < 5; i++)
        {
            if (PlayerPrefs.HasKey("Leader" + (i + 1)) && PlayerPrefs.HasKey("Score" + (i + 1)))
            {
                string name = PlayerPrefs.GetString("Leader" + (i + 1));
                int score = PlayerPrefs.GetInt("Score" + (i + 1));
                leaders += $"{(i + 1)}. {name.PadRight(15)} ............ {score, 8}\n";
            }
        }
        txtLeaders.text = leaders;
    }
}
