using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject Green_Enemy_Prefab;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Green Enemy Instansiated");
        Instantiate(Green_Enemy_Prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
