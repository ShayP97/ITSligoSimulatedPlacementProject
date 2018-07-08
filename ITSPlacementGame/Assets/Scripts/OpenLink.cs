using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenLink : MonoBehaviour
{
    public void OpenLink1()
    {
        Application.OpenURL("https://www.humanesociety.com");
    }

    public void OpenLink2()
    {
        Application.OpenURL("http://www.hsi.org/world/");
    }

}
