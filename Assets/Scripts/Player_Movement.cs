using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movement_speed = 1.0f;

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
