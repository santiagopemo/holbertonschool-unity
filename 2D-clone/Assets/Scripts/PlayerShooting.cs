using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireDelay = 0.25f;
    public Vector3 bulletOffset =  new Vector3(0, 0.5f, 0);
    private float cooldownTimer = 0;
    private int bulletLayer;
    // Start is called before the first frame update
    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        bool fireKey;
        if (gameObject.CompareTag("Player1"))
            fireKey = Input.GetButton("Fire1");
        else
            fireKey = Input.GetButton("Fire2");
        if (fireKey && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject bulletGO = (GameObject) Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            bulletGO.layer = bulletLayer;
        }
    }
}
