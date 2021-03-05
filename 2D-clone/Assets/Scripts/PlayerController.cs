using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5f;
    // private float rotSpeed = 180f;

    private float shipBoundary = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal;
        float vertical;
        if (gameObject.CompareTag("Player1"))
        {
            horizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            vertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        }
        else
        {
            horizontal = Input.GetAxis("Horizontal2") * speed * Time.deltaTime;
            vertical = Input.GetAxis("Vertical2") * speed * Time.deltaTime;
        }
        Vector3 pos = transform.position + new Vector3(horizontal, vertical, 0);

        if (pos.y + shipBoundary > Camera.main.orthographicSize)
        {
            pos.y = Camera.main.orthographicSize - shipBoundary;
        }
        if (pos.y - shipBoundary < -Camera.main.orthographicSize)
        {
            pos.y = -Camera.main.orthographicSize + shipBoundary;
        }

        float screenRatio = (float)Screen.width / (float)Screen.height;
        float widthOrtho = Camera.main.orthographicSize * screenRatio;

        if (pos.x + shipBoundary > widthOrtho)
        {
            pos.x = widthOrtho - shipBoundary;
        }
        if (pos.x - shipBoundary < -widthOrtho)
        {
            pos.x = -widthOrtho + shipBoundary;
        }
        transform.position = pos;
    }
}
