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

    //void Start()
    //{

    //    //while(spawned_cubes < set_spawn)
    //    //{
    //    //    spawn_position = new Vector3(Random.Range(-4.5f, 4.5f), 6.0f, 0); 
    //    //    Instantiate(Green_Enemy_Prefab, spawn_position, Quaternion.identity);
    //    //    spawned_cubes++;

    //    //}
    //    StartCoroutine("Spawn_Cubes");
    //}

    //IEnumerator Spawn_Cubes()
    //{
    //    spawn_position = new Vector3(Random.Range(-4.5f, 4.5f), 6.0f, 0);
    //    Instantiate(Green_Enemy_Prefab, spawn_position, Quaternion.identity);
    //    spawned_cubes++;

    //    yield return new WaitForSeconds(0.1f);

    //}
}
