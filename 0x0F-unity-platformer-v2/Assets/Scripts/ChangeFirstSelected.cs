using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ChangeFirstSelected : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas1;
    public GameObject canvas1First;
    public GameObject canvas2;
    public GameObject canvas2First;

    private bool canvas1Active = false;
    private bool canvas2Active = false;

    EventSystem eventSystem;

    void OnEnable()
    {
        eventSystem = EventSystem.current;
    }
    void Start()
    {
    }

    void Update()
    {
        if (canvas1.activeInHierarchy && !canvas1Active)
        {
            eventSystem.SetSelectedGameObject(canvas1First);
            canvas1Active = true;
            canvas2Active = false;
        }
        if (canvas2.activeInHierarchy && !canvas2Active)
        {
            eventSystem.SetSelectedGameObject(canvas2First);
            canvas1Active = false;
            canvas2Active = true;
        }
        if((!canvas1.activeInHierarchy && canvas1Active) || (!canvas2.activeInHierarchy && canvas2Active))
        {
            canvas1Active = false;
            canvas2Active = false;
        }
    } 
}
