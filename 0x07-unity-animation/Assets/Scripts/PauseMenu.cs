using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseCanvas;
    public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Confined;
        paused = false;
        Time.timeScale = 1;
        pauseCanvas.transform.Find("RestartButton").gameObject.GetComponent<Button>().onClick.AddListener(Restart);
        pauseCanvas.transform.Find("MenuButton").gameObject.GetComponent<Button>().onClick.AddListener(MainMenu);
        pauseCanvas.transform.Find("OptionsButton").gameObject.GetComponent<Button>().onClick.AddListener(Options);
        pauseCanvas.transform.Find("ResumeButton").gameObject.GetComponent<Button>().onClick.AddListener(Resume);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Resume();
            else
                Pause();
        }        
    }

    public void Pause()
    {
        // Cursor.visible = true;
        // Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        paused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        paused = false;
        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Confined;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Options()
    {
        PlayerPrefs.SetString("previous-scene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
