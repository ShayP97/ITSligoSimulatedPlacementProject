using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject settingsPanel;

    public void openPanel()
    {
        settingsPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }
    public void ClosePanel()
    {
        settingsPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

}
