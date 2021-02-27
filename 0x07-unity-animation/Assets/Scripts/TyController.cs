using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyController : MonoBehaviour
{
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent.gameObject;
    }

    public void TyIsFalling()
    {
        parent.GetComponent<PlayerController>().isFalling = true;
    }

    public void TyGotUp()
    {
        parent.GetComponent<PlayerController>().isFalling = false;
    }
}
