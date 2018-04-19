using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadText : MonoBehaviour
{
    public GameObject textPanel;
    public GameObject surePanel;
    public GameObject goPanel;

    public void SureButton()
    {
        textPanel.SetActive(true);
        surePanel.SetActive(false);
        goPanel.SetActive(true);

    }

}
