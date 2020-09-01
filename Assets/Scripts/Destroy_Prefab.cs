using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Prefab : MonoBehaviour
{
    public GameObject prefab;
    float despawn_distance = -5.0f;
    public int destroyed_cubes;
    // Start is called before the first frame update
    void Update()
    {      
        if(gameObject.transform.position.y <= despawn_distance)
        {
            Destroy(gameObject);
            Debug.Log("<color=red>Prefab Destroyed</color>");
        }  
    }
}
