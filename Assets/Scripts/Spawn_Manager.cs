using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject Green_Enemy_Prefab;
    public int max_spawn;
    public int spawn_cubes;
    public Vector3 spawn_position;
    
    // Start is called before the first frame update
    void Start()
    {
        int spawned = 0;
        while(spawn_cubes < max_spawn)
        {
            spawn_position = new Vector3(Random.Range(-4.5f, 4.5f), 6.0f, 0); 
            Instantiate(Green_Enemy_Prefab, spawn_position, Quaternion.identity);
            spawn_cubes++;
        }
    }
}
