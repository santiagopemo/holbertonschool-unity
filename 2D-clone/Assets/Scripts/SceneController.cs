using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public PlayerSpawner p1spawner;
    public PlayerSpawner p2spawner;

    public ScoreCanvas scoreCanvas;
    public GameObject gameOverCanvas;
    public GameObject pauseCanvas;
    private int numPlayers = 1;
    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("NumPlayers"))
        {
            numPlayers = PlayerPrefs.GetInt("NumPlayers");
        }
        if (numPlayers == 2)
        {
            p2spawner.gameObject.SetActive(true);
            scoreCanvas.setLivesP2();            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            if (numPlayers == 2)
            {
                if (scoreCanvas.p1Lives.transform.childCount == 0 && scoreCanvas.p2Lives.transform.childCount == 0)
                {
                    OnGameOver();
                }
            }
            else if (numPlayers == 1)
            {
                if (scoreCanvas.p1Lives.transform.childCount == 0)
                {
                    OnGameOver();
                }
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                OnPause();
            }
        }
        
    }
    void OnGameOver()
    {
        gameOverCanvas.SetActive(true);
        gameOver = true;
        PlayerPrefs.SetInt("CurrentScore", scoreCanvas.totalScore);
    }
    void OnPause()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
    }
}
