using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject Green_Enemy_Prefab;
    public Vector3 spawn_position;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Green Enemy Instansiated");
        Instantiate(Green_Enemy_Prefab, new Vector3(Random.Range(-4.5f, 4.5f), 0, 0), Quaternion.identity);

        //int spawned = 0;

        //while(spawned < 2)
        //{
        //    spawn_position = new Vector3(Random.Range(-4.5f, 4.5f), 6.0f, 0);
        //    Instantiate(Green_Enemy_Prefab, spawn_position, Quaternion.identity);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
