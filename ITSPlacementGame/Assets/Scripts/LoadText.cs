using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject textPanel2;
    public GameObject surePanel;
    public GameObject goPanel;
    public GameObject thanksPanel;
 

    public void SureButton()
    {
        textPanel.SetActive(true);
        surePanel.SetActive(false);
        goPanel.SetActive(true);
    }

    public void SureButton2()
    {
        textPanel.SetActive(true);
        surePanel.SetActive(false);
        thanksPanel.SetActive(true);
    }

    public void ThanksButton()
    {
        textPanel2.SetActive(true);
        thanksPanel.SetActive(false);
        goPanel.SetActive(true);
    }

}
