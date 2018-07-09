using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlaying : MonoBehaviour
{
    private static MusicPlaying instance = null;
    public static MusicPlaying Instance
    {
        get{ return instance; }
    }

    private void Awake()
    {
        //Keeps the Menu music playing through all of the menu scenes
        if(instance != null && instance != this )
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        //Stops the Menu music from playing after it enters the Main Scene
        if (SceneManager.GetActiveScene().name == "Main Scene") 
        {
            Destroy(gameObject);
        }
        else if(SceneManager.GetActiveScene().name == "MainScene_2")
        {
            Destroy(gameObject);
        }
        else if(SceneManager.GetActiveScene().name == "Ending")
        {
            Destroy(gameObject);
        }
    }
}
