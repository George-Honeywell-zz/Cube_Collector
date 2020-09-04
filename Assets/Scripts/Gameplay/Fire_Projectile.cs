using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Projectile : MonoBehaviour
{
    public Rigidbody projectile; 
    public Transform projectile_start;
    public float fire_speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rb = Instantiate(projectile, projectile_start.position, transform.rotation);
            rb.velocity = transform.up * fire_speed;
        }
        
    }
}
