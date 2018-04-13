using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField]
    public Text InputField;

    string inputValue;

    int[] Num = new int[2];

    int argument;
    int i = 0;

    public void ButtonSelected()
    {
        string bValue = EventSystem.current.currentSelectedGameObject.name;
        InputField.text = bValue;

        if(int.TryParse(bValue, out argument))
        {
            if (i > 1) i = 0;
            Num[i] = argument;
            i = i++;   
        }

        inputValue += bValue;
        InputField.text = inputValue;
        Num = new int[2];

    }	

}
