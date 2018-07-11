using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    string Cafe1;
    string Cafe2;
    string Cafe3;

    private int randomScene;

    private void Start()
    {
        randomScene = Random.Range(0, 4);
        
         if(randomScene == 1)
        {
            Debug.Log("Scene1");
            SceneManager.LoadScene("Cafe");
        }

        if (randomScene == 2)
        {
            Debug.Log("Scene2");
            SceneManager.LoadScene("CafeMinigame1Q2");
        }

        if (randomScene == 3)
        {
            Debug.Log("Scene3");
            SceneManager.LoadScene("CafeMinigame1Q3");
        }
    }

}
