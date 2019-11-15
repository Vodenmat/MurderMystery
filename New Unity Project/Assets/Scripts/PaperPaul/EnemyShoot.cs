using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform player;
    public float bulletSpeed = 10f;
    public float playerDistanceMin = 10;
    private float playerDistance = 0;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = shootDelay;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 shootDirection = new Vector2(player.position.x - transform.position.x, player.position.y - transform.position.y);
        playerDistance = shootDirection.magnitude;
        timer += Time.deltaTime;
        if (timer > shootDelay && playerDistance < playerDistanceMin)
        {
            shootDirection.Normalize();
            Vector3 spawnPosition = transform.position;
            GameObject bullet = Instantiate(prefab, spawnPosition, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            timer = 0;
        }
    }
}
/*transform.position.x - player.transform.position.x]^2 + [transform.position.y - player.transform.position.y]^2*/