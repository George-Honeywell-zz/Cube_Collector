using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time_left = 30.0f;
    public Text time_text;

    // Update is called once per frame
    void Update()
    {
        if(time_left > 0)
        {
            time_left -= Time.deltaTime;
            Debug.Log(time_left);
            time_text.text = time_left.ToString("00");
        }
    
        if(time_left <= 0)
        {
            Application.Quit();
        }

    }
}
