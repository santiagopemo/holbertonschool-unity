using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvas : MonoBehaviour
{
    public Text txtScore;
    public GameObject p1Lives;
    public GameObject p2Lives;
    public PlayerSpawner player1Spawner;
    public PlayerSpawner player2Spawner;

    public Sprite imageP1;
    public Sprite imageP2;

    public int totalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        setLivesP1();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddToScore(int value)
    {
        totalScore += value;
        txtScore.text = string.Format("{0,0:D5}", totalScore);
    }

    public void DecreaseP1Lives()
    {
        if (p1Lives.transform.childCount > 0)
        {
            GameObject firsLife = p1Lives.transform.GetChild(0).gameObject;
            if (firsLife != null)
                Destroy(firsLife);
        }
    }

    public void DecreaseP2Lives()
    {
        if (p2Lives.transform.childCount > 0)
        {
            GameObject firsLife = p2Lives.transform.GetChild(0).gameObject;
            if (firsLife != null)
                Destroy(firsLife);
        }            
    }

    public void setLivesP1()
    {
        for (int i = 0; i < player1Spawner.lives; i++)
        {
            GameObject imgGO = new GameObject();
            Image img = imgGO.AddComponent<Image>();
            img.sprite = imageP1;
            imgGO.GetComponent<Transform>().SetParent(p1Lives.transform);
            imgGO.SetActive(true);
        }
    }

    public void setLivesP2()
    {
        for (int i = 0; i < player2Spawner.lives; i++)
        {
            GameObject imgGO = new GameObject();
            Image img = imgGO.AddComponent<Image>();
            img.sprite = imageP2;
            imgGO.GetComponent<Transform>().SetParent(p2Lives.transform);
            imgGO.SetActive(true);
        }
    }
}
