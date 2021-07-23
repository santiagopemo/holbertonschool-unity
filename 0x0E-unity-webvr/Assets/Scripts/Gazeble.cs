using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gazeble : MonoBehaviour
{
    public Canvas infoCanvas;
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
        Interactable interactable;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            interactable = hit.transform.gameObject.GetComponent<Interactable>();
            if (interactable != null && Input.GetMouseButton(0) == false)
            {
                infoCanvas.gameObject.SetActive(true);
                interactable.PlaceInfo();
            }
            else
            {
                infoCanvas.gameObject.SetActive(false);
            }

        }

    }
}
