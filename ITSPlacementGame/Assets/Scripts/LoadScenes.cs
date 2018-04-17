using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public void LoadCafe()
    {
        SceneManager.LoadScene("Cafe");
    }

    public void LoadPO()
    {
        SceneManager.LoadScene("PostOfficeMinigame1");
    }

}
