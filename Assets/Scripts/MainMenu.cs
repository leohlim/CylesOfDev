// Built in
using System.Collections;
using System.Collections.Generic;

// Unity
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    
    public AudioClip buttonPress;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    

    public void QuitGame()
    {
        Application.Quit();
    }




}
