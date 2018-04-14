using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField]
    public Text inputField;

    string inputValue;

    string enter;

    //int[] Num = new int[2];

    //int argument;
    //int i = 0;

    public void ButtonSelected()
    {
        string bValue = EventSystem.current.currentSelectedGameObject.name; //grabs the name of the button that was pressed

        inputField.text += bValue; //displays the numbers that were selected
        enter = inputField.text;


        //if(int.TryParse(bValue, out argument))
        //{
        //    if (i > 1) i = 0;
        //    Num[i] = argument;
        //    i = i++;   
        //}

        //inputValue += bValue;

        //inputField.text = inputValue;

    }	

    public void BackButton()
    {
        inputField.text = " "; //Clears the current display
    }

}
