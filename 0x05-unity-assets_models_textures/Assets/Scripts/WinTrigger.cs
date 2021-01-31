using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
         player = FindObjectOfType<PlayerController>().gameObject;
         timerText = GameObject.Find("TimerCanvas").transform.Find("TimerText").GetComponent<Text>();
    }

    void OnTriggerEnter(Collider other)
    {
        player.GetComponent<Timer>().enabled = false;
        timerText.color = Color.green;
        timerText.fontSize = 60;
    }
}
