using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void Option()
    {
        SceneManager.LoadScene(4);
    }

    public void SavedScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", currentScene);
    }
    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }

}