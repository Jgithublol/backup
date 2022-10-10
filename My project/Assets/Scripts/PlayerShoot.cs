using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletSpeed = 10.0f;
    public float bulletLifetime = 2.0f;
    public float shootDelay = 1.0f;
    float timer = 0;

    public AudioClip shootSound;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButtonDown("Fire1"))
        {
            if(timer >= shootDelay)
            {
                if(Time.timeScale > 0)
                {
                    GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
                    Vector3 mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    Vector3 shootDir = mousePosition - transform.position;
                    shootDir.Normalize();
                    bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
                    Destroy(bullet, bulletLifetime);

                    Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                }
            }
        }
    }
}
