using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject Green_Enemy_Prefab;
    public int set_spawn;
    public int spawned_cubes;
    public Vector3 spawn_position;

    public float spawn_time = 0.5f;
    private float current_spawn_time;

    void Start()
    {
        current_spawn_time = spawn_time;
    }

    void Update()
    {
        current_spawn_time -= 1 * Time.deltaTime;
        if(current_spawn_time <= 0)
        {
            Spawn_Cubes();
            current_spawn_time = spawn_time;
        }
    }

    void Spawn_Cubes()
    {
         spawn_position = new Vector3(Random.Range(-4.5f, 4.5f), 8.0f, 0);
         Instantiate(Green_Enemy_Prefab, spawn_position, Quaternion.identity);
         spawned_cubes++;
    }
}
