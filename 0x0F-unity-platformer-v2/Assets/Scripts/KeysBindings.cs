using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class KeysBindings : MonoBehaviour
{
    public InputActionAsset inputActions;
    public Toggle triggerToggle;
    public Slider sensitivitySlider;
    private bool lookTrigger = true;
    private float lookSensitivity = 30f; 
    // Start is called before the first frame update
    void Start()
    {
        
        if (PlayerPrefs.HasKey("LookSensitivity"))
            lookSensitivity = PlayerPrefs.GetFloat("LookSensitivity");
        if (PlayerPrefs.HasKey("LookTrigger"))
            lookTrigger = PlayerPrefs.GetInt("LookTrigger") == 0 ? false : true;
        sensitivitySlider.value = lookSensitivity;
        triggerToggle.isOn = lookTrigger; 
    }
    void OnEnable()
    {
        
    }

    public void SetLookTrigger(bool value)
    {
        lookTrigger = value;
    }

    public void SetLookSensitivity(float value)
    {
        lookSensitivity = value;
    }

    public void ResetBindings()
    {
        foreach (InputActionMap map in inputActions.actionMaps)
        {
            map.RemoveAllBindingOverrides();
        }
        PlayerPrefs.DeleteKey("rebinds");
        sensitivitySlider.value = 30f;
        triggerToggle.isOn = true; 
        lookTrigger = true;
        lookSensitivity = 30f; 
    }
    public void ExitBindings()
    {
        PlayerPrefs.SetFloat("LookSensitivity", lookSensitivity);
        PlayerPrefs.SetInt("LookTrigger", lookTrigger == true ? 1 : 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
