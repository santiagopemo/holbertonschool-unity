using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    public int health = 1;
    public float invulnPeriod = 0;
    private float invulnTimer = 0;
    private int correctLayer;
    private SpriteRenderer spriteRenderer;
    ScoreCanvas scoreCanvas;
    void Start()
    {
        scoreCanvas = GameObject.FindObjectOfType<ScoreCanvas>();
        correctLayer = gameObject.layer;
        spriteRenderer = GetComponent<SpriteRenderer>();
        if(spriteRenderer == null)
        {
            spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            if (spriteRenderer == null)
            {
                Debug.Log("No SpriteRenderer");
            }
        }
    }
    void OnTriggerEnter2D()
    {
        health--;
        invulnTimer = invulnPeriod;
        gameObject.layer = 10;
       
    }
    void Update()
    {
        if (invulnTimer > 0)
        {
            invulnTimer -= Time.deltaTime;
            if (invulnTimer <= 0)
            {
                gameObject.layer = correctLayer;
                spriteRenderer.enabled = true;
            }
            else
            {
                spriteRenderer.enabled = !spriteRenderer.enabled;
            }
        }
        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        if (gameObject.CompareTag("StaticEnemy"))
            scoreCanvas.AddToScore(5);
        if (gameObject.CompareTag("MobileEnemy"))
            scoreCanvas.AddToScore(10);
        if (gameObject.CompareTag("AdvanceEnemy"))
            scoreCanvas.AddToScore(15);
        if (gameObject.CompareTag("KamikazeEnemy"))
            scoreCanvas.AddToScore(20);
        if (gameObject.CompareTag("Player1"))
            scoreCanvas.DecreaseP1Lives();
        if (gameObject.CompareTag("Player2"))
            scoreCanvas.DecreaseP2Lives();
        Destroy(gameObject);
        
    }
}
