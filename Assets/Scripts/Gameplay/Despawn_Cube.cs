using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Despawn_Cube : MonoBehaviour
{
    public Text missed_cubes;
    int missed = 0;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Green_Enemy"))
        {
            Destroy(other.gameObject);
            missed++;
            missed_cubes.text = missed.ToString();
        }
    }
}
