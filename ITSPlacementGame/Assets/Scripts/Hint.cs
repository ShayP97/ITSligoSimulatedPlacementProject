using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject hintMessage;

    public void HintButton()
    {
        hintMessage.SetActive(true);
    }

}
