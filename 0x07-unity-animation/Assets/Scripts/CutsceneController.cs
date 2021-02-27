using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public GameObject player;
    public GameObject timerCanvas;

    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void OnIntroFisnished()
    {
        player.GetComponent<PlayerController>().enabled = true;
        timerCanvas.SetActive(true);
        mainCamera.SetActive(true);
        gameObject.SetActive(false);
    }
    void Update()
    {

    }
}
