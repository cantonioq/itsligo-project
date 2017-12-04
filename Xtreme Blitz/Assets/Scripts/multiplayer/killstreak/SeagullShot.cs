using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeagullShot : MonoBehaviour
{

    //for ennemy shots
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireRate;
    private float nextFire;

    public float time;

    // Use this for initialization
    void Start()
    {
        time = Random.Range(8, 25);
    }

    // Update is called once per frame
    void Update()
    {
        //if (GameObject.Find("seagull").GetComponent<killstreakSeagull>().time < -5.0f)
        // if (Input.GetKeyDown(KeyCode.A))
        //if (transform.position.x < -20.0f)
        time -= Time.deltaTime;

        if (time < 0.0f)
        {
            Fire();
            Debug.Log("fire");
            time += 37.0f;
        }
    }


    void Fire()
    {

        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            // Create the Bullet from the Bullet Prefab
            var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

            // Add velocity to the bullet
            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.up / 6;

            // Destroy the bullet after 2 seconds
            Destroy(bullet, 6.0f);

        }
    }

    private void EnnemyShoot()
    {


    }
}