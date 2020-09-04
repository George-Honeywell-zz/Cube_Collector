using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Manager : MonoBehaviour
{
    public Text cube_score;
    int score = 0;   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Green_Enemy"))
        {
            Destroy(other.gameObject);
            score++;
            cube_score.text = score.ToString();
        }
    }
}
