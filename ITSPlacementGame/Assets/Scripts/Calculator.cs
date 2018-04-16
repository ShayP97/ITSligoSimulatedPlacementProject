/*
 *Authour: Shay Pitcher
 * 
 * Function: Allows the user to input their answer to the current question
*/

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

    public GameObject correctPanel;

    public GameObject wrongPanel;

    public GameObject nextPanel;

    public Button nextButton1;

    public Button nextButton2;

    public Button nextButton3;

    string inputValue;

    string enter;

    string answer;

    public void ButtonSelected()
    {
        string bValue = EventSystem.current.currentSelectedGameObject.name; //grabs the name of the button that was pressed

        inputField.text += bValue; //displays the numbers that were selected
    }	

    public void BackButton()
    {
        inputField.text = " "; //Clears the current display

        if (wrongPanel == true)
        {
            wrongPanel.SetActive(false);
        }

    }

    public void OKButton()
    {
        answer = inputField.text; //graps the current answer and stores it

        if(answer == "3.75") //checks for the correct answer
        {
            correctPanel.SetActive(true); //turns on the panel to display "Correct!"     
            nextPanel.SetActive(true);       
        }
        else
        {
            wrongPanel.SetActive(true); //tea + cookie & Milk + Chiken salad
        }

    }

    public void OKButton2()
    {
        answer = inputField.text; //graps the current answer and stores it

        if (answer == "2.00") //checks for the correct answer
        {
            correctPanel.SetActive(true); //turns on the panel to display "Correct!"   
            nextPanel.SetActive(true);
        }
        else
        {
            wrongPanel.SetActive(true); 
        }

    }

    public void OKButton3()
    {
        answer = inputField.text; //graps the current answer and stores it

        if (answer == "5.75") //checks for the correct answer
        {
            correctPanel.SetActive(true); //turns on the panel to display "Correct!"            
        }
        else
        {
            wrongPanel.SetActive(true); //tea + cookie & Milk + Chiken salad
        }

    }

}
