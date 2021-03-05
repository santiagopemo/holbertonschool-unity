using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemyStandard : MonoBehaviour
{
    public float speed = 2f;
    private float shipBoundary = 0.5f;
    
    [Range(0, 1)]
    public float horizontalSpan = 0;
    private Vector3 pos;

    private bool movingVerticaly = true;
    private float screenRatio;
    private float widthOrtho;
    private float newX;
    void Start()
    {
        transform.Rotate(0, 0, 180);
        DefineRandomPosition();
        newX = (widthOrtho - shipBoundary) * horizontalSpan;

    }

    void DefineRandomPosition(){
        float randomY = Random.Range(Camera.main.transform.position.y, Camera.main.orthographicSize - shipBoundary);
        screenRatio = (float)Screen.width / (float)Screen.height;
        widthOrtho = Camera.main.orthographicSize * screenRatio;
        float randomX = Random.Range(-widthOrtho + shipBoundary, widthOrtho - shipBoundary);
        pos = new Vector3(randomX, randomY, 0);
    }
    
    void Update()
    {
        if (movingVerticaly)
        {
            transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, pos) == 0.0f && horizontalSpan > 0.0f)
            {
                movingVerticaly = false;
                pos = new Vector3(newX, transform.position.y, 0);
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, pos) == 0.0f)
            {
                newX *= -1;
                pos = new Vector3(newX, transform.position.y, 0);
            }
        }
        
    }
}
