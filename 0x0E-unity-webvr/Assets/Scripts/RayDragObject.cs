using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RayDragObject : MonoBehaviour
{
    private bool dragging = false;
    private Transform lastParent;
    private Interactable interactable;

    public Text debugText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Camera>().enabled == false)
            return;
        RaycastHit hit;
        if (Input.GetAxisRaw("Fire3") != 0 && dragging == false)
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                interactable = hit.transform.gameObject.GetComponent<Interactable>();
                if (interactable != null)
                {

                    if (interactable.GetComponent<Rigidbody>() != null)
                    {
                        lastParent = interactable.transform.parent;
                        interactable.transform.parent = this.transform;
                        interactable.GetComponent<Rigidbody>().isKinematic = true;
                        dragging = true;
                        interactable.audioSource.Play();
                    }
                }
            }
        }
        if (Input.GetAxisRaw("Fire3") == 0 && dragging == true)
        {
            interactable.transform.parent = lastParent;
            interactable.GetComponent<Rigidbody>().isKinematic = false;
            dragging = false;
        }
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            Debug.Log("Detected key code: " + e.keyCode);
            debugText.text = "Detected key code: " + e.keyCode;
        }
    }
}