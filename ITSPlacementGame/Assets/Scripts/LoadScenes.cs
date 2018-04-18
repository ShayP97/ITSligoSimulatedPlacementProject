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

    public void LoadBCFact()
    {
        SceneManager.LoadScene("BCFact");
    }

    public void LoadPostScene2()
    {
        SceneManager.LoadScene("PostOfficeMinigame2");
    }
    public void LoadNVFact()
    {
        SceneManager.LoadScene("NVFact");
    }

    public void LoadPostScene3()
    {
        SceneManager.LoadScene("PostOfficeMinigame3");
    }

    public void LoadONFact()
    {
        SceneManager.LoadScene("ONFact");
    }

}
