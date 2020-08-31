﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //public Rigidbody Player;
    public float movement_speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * movement_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position -= Vector3.left * movement_speed * Time.deltaTime;
        }
    }
}