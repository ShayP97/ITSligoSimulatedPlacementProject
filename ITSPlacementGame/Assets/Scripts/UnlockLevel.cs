using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public GameObject postPanel;

    [SerializeField]
    public Text inputFieldMain;

    public string postPass;

    public void UnlockPost()
    {
        postPass = inputFieldMain.text;

        if (postPass == "STAMPS")
        {
            postPanel.SetActive(true);
        }

    }

}
