using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    public GameObject postPanel;

    public void LoadMainScene()
    {
        SceneManager.LoadScene("Main Scene");
        //postPanel.SetActive(true);
    }

    public void ReLoadMainScene()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void LoadCafe()
    {
        SceneManager.LoadScene("Cafe");
    }

    public void LoadCafeIntro()
    {
        SceneManager.LoadScene("CafeIntro");
    }

    public void LoadPOIntro()
    {
        SceneManager.LoadScene("PostOfficeIntro");
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

    IEnumerator ChangeScene()
    {
        float fadeTime = GameObject.Find("Fade_Oject").GetComponent<SceneFadeIn>().BeginFadeIn(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(Application.loadedLevel + 1); 
    }

}
