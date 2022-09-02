using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    void Start()
    {
        Destroy(bulletPrefab, 5f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        
    }

    void Shoot()
    {
        GameObject rightBullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = rightBullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        GameObject rightBullet2 = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
        Rigidbody2D rb2 = rightBullet2.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        GameObject leftBullet = Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
        Rigidbody2D rb3 = leftBullet.GetComponent<Rigidbody2D>();
        rb3.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);

        GameObject leftBullet2 = Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
        Rigidbody2D rb4 = leftBullet2.GetComponent<Rigidbody2D>();
        rb4.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
    }
}
