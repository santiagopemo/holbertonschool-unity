using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactable : MonoBehaviour
{
    public Canvas infoCanvas;
    public Text infoText;

    public AudioSource audioSource;

    [TextArea]
    public string objectInfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaceInfo ()
    {
        infoCanvas.transform.position = new Vector3(transform.position.x, transform.position.y + 0.6f, transform.position.z);
        infoText.text = objectInfo;
    }

    void OnMouseDown()
    {
        audioSource?.Play();
    }
}
