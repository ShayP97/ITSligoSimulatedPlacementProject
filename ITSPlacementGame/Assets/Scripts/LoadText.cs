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
    public GameObject okTextPanel;
    public GameObject nextTextPanel;
 

    public void SureButton()
    {
        textPanel.SetActive(true);
        surePanel.SetActive(false);
        goPanel.SetActive(true);
    }

    public void SureButton2()
    {
        textPanel.SetActive(false);
        textPanel2.SetActive(true);
        surePanel.SetActive(false);
        goPanel.SetActive(true);
    }

    public void PostOkButton()
    {
        textPanel.SetActive(true);
        surePanel.SetActive(false);
        okTextPanel.SetActive(false);
        goPanel.SetActive(true);
    }

    public void BookIntroText()
    {
        textPanel.SetActive(false);
        textPanel2.SetActive(true);
        surePanel.SetActive(false);
        nextTextPanel.SetActive(true);
        
    }

    public void BookText2()
    {
        textPanel2.SetActive(false);
        nextTextPanel.SetActive(false);
        okTextPanel.SetActive(true);
        goPanel.SetActive(true);
    }

    public void ThanksButton()
    {
        textPanel2.SetActive(true);
        thanksPanel.SetActive(false);
        goPanel.SetActive(true);
    }

}
