using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy_Prefab : MonoBehaviour
{
    public GameObject prefab;
    float despawn_distance = -5.0f;
    public int missed_cubes = 0;

 
    void Update()
    {
        Destroy_prefab();
    }

    public void Destroy_prefab()
    {
        if (gameObject.transform.position.y <= despawn_distance)
        {
            Destroy(gameObject);
            missed_cubes++;
            Debug.Log("<color=red>Prefab Destroyed</color>");
        }
    }
}
