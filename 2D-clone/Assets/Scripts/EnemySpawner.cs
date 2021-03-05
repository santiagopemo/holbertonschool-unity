using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    float spawnDistance = 20f;
    public float enemyRate = 5;
    [Range(0.8f, 1f)]
    public float minRate = 1;
    float nextEnemy = 1;
    public float rateTime = 5;
    private float deltaRateTime;

    public SceneController sceneController;
    // Start is called before the first frame update
    void Start()
    {
        sceneController = FindObjectOfType<SceneController>();
        deltaRateTime = rateTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneController.gameOver)
            return;
        
        nextEnemy -= Time.deltaTime;
        deltaRateTime -= Time.deltaTime;
        if (deltaRateTime <= 0)
        {
            deltaRateTime = rateTime;
            enemyRate *= minRate;
            if (enemyRate <= enemyRate / 3)
                enemyRate = enemyRate / 3;
        }
        

        if(nextEnemy <= 0)
        {
            nextEnemy = enemyRate;

            // Vector3 offset = Random.onUnitSphere;
            Vector3 offset = Vector3.zero;
            offset.z = 0;
            offset = offset.normalized * spawnDistance;
            Instantiate(enemyPrefab, transform.position + offset, Quaternion.identity);
        }
    }
}
