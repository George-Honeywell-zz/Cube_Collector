using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision_Manager : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    public Text cube_score;
    
    void OnTriggerEnter(Collider other)
    {
        int score = 0;
        if(other.gameObject.CompareTag("Green_Enemy"))
        {
            
            Debug.Log("Collected Cube");
            Destroy(other.gameObject);
            score++;
            cube_score.text = score.ToString();
            
        }
    }
}
