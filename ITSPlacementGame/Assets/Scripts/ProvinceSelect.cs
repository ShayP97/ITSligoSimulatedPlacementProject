using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProvinceSelect : MonoBehaviour
{
    public GameObject checkPanel;
    public GameObject sendButton;

    public void CorrectProvince1()
    {
        checkPanel.SetActive(true);
        sendButton.SetActive(true);
    }
    public void CorrectProvince2()
    {
        checkPanel.SetActive(true);
        sendButton.SetActive(true);
    }

    public void CorrectCity()
    {
        checkPanel.SetActive(true);
        sendButton.SetActive(true);
    }

}
