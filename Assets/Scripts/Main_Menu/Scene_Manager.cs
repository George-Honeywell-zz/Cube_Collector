using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    public GameObject Main_Menu;
    public GameObject About_Button;
    public GameObject Back_Button;


    public void Change_Scene(int scene_id)
    {
        SceneManager.LoadScene(scene_id);
    }

    public void About()
    {
        About_Button.SetActive(true);
        Main_Menu.SetActive(false); 
    }

    public void Back()
    {
        Main_Menu.SetActive(true);
        About_Button.SetActive(false);
    }

    public void GitHub_Link()
    {
        Application.OpenURL("https://github.com/George-Honeywell/DirectX_Project");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
