using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    private Toggle invertYAxis;
    void Start()
    {
        transform.Find("ApplyButton").gameObject.GetComponent<Button>().onClick.AddListener(Apply);
        invertYAxis = transform.Find("InvertYToggle").gameObject.GetComponent<Toggle>();
        if (PlayerPrefs.HasKey("InvertYToggle"))
            invertYAxis.isOn = PlayerPrefs.GetInt("InvertYToggle") == 0 ? false : true;
        
    }
    public void Back()
    {
        if (PlayerPrefs.HasKey("previous-scene"))
            SceneManager.LoadScene(PlayerPrefs.GetString("previous-scene"));
    }

    public void Apply()
    {
        if (invertYAxis.isOn)
            PlayerPrefs.SetInt("InvertYToggle", 1);
        else
            PlayerPrefs.SetInt("InvertYToggle", 0);
        Back();
    }
}
