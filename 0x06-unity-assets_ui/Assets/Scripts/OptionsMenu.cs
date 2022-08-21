using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public void SavedScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("previous", currentScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("__isInverted__") == "true")
        {
            GameObject.Find("InvertYToggle").GetComponent<Toggle>().isOn = true;
        }
    }
    /// Loads the last scene
    public void Back()
    {
       int currentScene = PlayerPrefs.GetInt("previous");
       SceneManager.LoadScene(currentScene);
    }
    /// Saves changes in the option menu.
    public void Apply()
    {
       bool isInverted = GameObject.Find("InvertYToggle").GetComponent<Toggle>().isOn;
       PlayerPrefs.SetString("__isInverted__", "false");
       if (isInverted)
       {
         PlayerPrefs.SetString("__isInverted__", "true");
       }
    }
}
