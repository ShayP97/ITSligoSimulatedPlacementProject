using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject textPanel2;
    public GameObject TextPanel3;
    public GameObject btnPanel;
    public GameObject goPanel;
    public GameObject thanksPanel;
    public GameObject nextTextPanel;
 

    public void LoadOneText()
    {
        textPanel.SetActive(true);
        btnPanel.SetActive(false);
        goPanel.SetActive(true);
    }

    public void LoadThreeText()
    {
        textPanel.SetActive(false);
        textPanel2.SetActive(true);
        btnPanel.SetActive(true);
        goPanel.SetActive(false);
    }

    public void PostOkButton()
    {
        textPanel.SetActive(true);
        btnPanel.SetActive(false);
        textPanel2.SetActive(false);
        goPanel.SetActive(true);
    }

    public void BookIntroText()
    {
        textPanel.SetActive(false);
        textPanel2.SetActive(true);
        btnPanel.SetActive(false);
        nextTextPanel.SetActive(true);
        
    }

    public void BookText2()
    {
        textPanel2.SetActive(false);
        nextTextPanel.SetActive(false);
        TextPanel3.SetActive(true);
        goPanel.SetActive(true);
    }

    public void ThanksButton()
    {
        textPanel2.SetActive(true);
        thanksPanel.SetActive(false);
        goPanel.SetActive(true);
    }

}
