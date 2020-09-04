using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movement_speed = 1.0f;
    public bool can_move_left = true;
    public bool can_move_right = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && can_move_left == true)
        {
            transform.position += Vector3.left * movement_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D) && can_move_right == true)
        {
            transform.position -= Vector3.left * movement_speed * Time.deltaTime;
        }

        if (gameObject.transform.position.x >= 4.6f)
        {
            can_move_right = false;
            Debug.Log("Unable to move RIGHT");
        }
        else
        {
            can_move_right = true;
        }

        if(gameObject.transform.position.x <= -4.6f)
        {
            can_move_left = false;
            Debug.Log("Unable to move LEFT");
        }
        else
        {
            can_move_left = true;
        }

    }
}
