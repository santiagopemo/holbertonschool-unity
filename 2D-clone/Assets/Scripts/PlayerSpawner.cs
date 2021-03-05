using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    GameObject playerInstance;
    private float respawnTimer;
    public int lives = 4;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPlayer();
    }
    void SpawnPlayer()
    {
        lives--;
        respawnTimer = 1;
        playerInstance = (GameObject) Instantiate(playerPrefab, transform.position, Quaternion.identity);
        playerInstance.name = "PlayerShip";        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInstance == null && lives > 0)
        {
            respawnTimer -= Time.deltaTime;

            if (respawnTimer <= 0)
            {
                SpawnPlayer();
            }
        }
    }

    // void OnGUI()
    // {
    //     if (lives > 0 || playerInstance != null)
    //         GUI.Label(new Rect(0, 0, 100, 50), "Lives left: " + lives);
    //     else
    //         GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Game Over!");
    // }
}
