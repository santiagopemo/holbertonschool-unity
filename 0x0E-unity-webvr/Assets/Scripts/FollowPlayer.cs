using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.LookAt(player);
        transform.forward = Camera.main.transform.forward;
        // transform.LookAt(Camera.main.transform);
    }
}
