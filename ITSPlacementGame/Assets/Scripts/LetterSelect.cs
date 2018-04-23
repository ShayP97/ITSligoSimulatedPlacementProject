using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LetterSelect : MonoBehaviour
{
    [SerializeField]
    public Text inputBox1;
    public Text inputBox2;

    string letter;

    public void SelectLetter()
    {
        letter = EventSystem.current.currentSelectedGameObject.name; //grabs the name of the button that was pressed

        inputBox1.text = letter; //displays the numbers that were selected
        inputBox2.text = letter;
    }

}
