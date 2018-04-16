using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CafeOneNextScene : MonoBehaviour
{
    public void NextButton1()
    {
        SceneManager.LoadScene("CafeMinigame1Q2");
    }

    public void NextButton2()
    {
        SceneManager.LoadScene("CafeMinigame1Q3");
    }

}
