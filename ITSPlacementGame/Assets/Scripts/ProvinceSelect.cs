using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProvinceSelect : MonoBehaviour
{
    public GameObject checkPanel;
    public GameObject sendButton;

    public void CorrectProvince()
    {
        checkPanel.SetActive(true);
        sendButton.SetActive(true);
    }

    //public void OnMouseClick()
    //{
    //    checkPanel.SetActive(true);
    //}
}
