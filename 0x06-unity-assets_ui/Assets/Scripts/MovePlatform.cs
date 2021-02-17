using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed = 1f;
    public Vector3 targetPosition;
    public Vector3 initialPosition;

    public bool forward = true;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (forward)
        {
            transform.position = Vector3.MoveTowards(transform.position,  targetPosition, step);
            if (Vector3.Distance(transform.position, targetPosition) == 0f)
                forward = false;
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position,  initialPosition, step);
            if (Vector3.Distance(transform.position, initialPosition) == 0f)
                forward = true;
        }
    }
}
