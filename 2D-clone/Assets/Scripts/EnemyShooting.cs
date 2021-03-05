using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireDelay = 0.5f;
    public Vector3 bulletOffset =  new Vector3(0, 0.5f, 0);
    private float cooldownTimer = 0;
    private int bulletLayer;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            GameObject go = GameObject.Find("PlayerShip");
            if (go != null)
            {
                player = go.transform;
            }
        }
        cooldownTimer -= Time.deltaTime;
        // if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 7)
        if (cooldownTimer <= 0 && player != null && Vector3.Distance(transform.position, player.position) < 10)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;            
            GameObject bulletGO = (GameObject) Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
    }
}
