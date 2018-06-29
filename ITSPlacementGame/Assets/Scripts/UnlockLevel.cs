using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public GameObject postPanel;
    public GameObject bookPanel;

    private TouchScreenKeyboard keyboard;

 
    [SerializeField]
    public Text inputFieldMain;

    public string postPass;
    public string bookPass;

    private void Start()
    {
        //postPanel.SetActive(true);
        //inputFieldMain.text = PlayerPrefs.GetString("Password");
    }

    //void OnGUI()
    //{
    //    postPass = GUI.TextField(new Rect(300, 80, 200, 80), postPass, 25);
    //    keyboard = TouchScreenKeyboard.Open(postPass, TouchScreenKeyboardType.Default, false, false, true, true);

    //    if (GUI.Button(new Rect(10, 50, 200, 100), "Default"))
    //    {
    //        keyboard = TouchScreenKeyboard.Open(postPass, TouchScreenKeyboardType.Default);
    //    }

    //    TouchScreenKeyboard.hideInput = true;


    //}

    public void UnlockPost()
    {
        postPass = inputFieldMain.text;
        
        if (postPass == "STAMPS")
        {           
            postPanel.SetActive(true);
            PlayerPrefs.SetString("Password", postPass);
        }
    }

    public void UnlockBook()
    {
        bookPass = inputFieldMain.text;

        if(bookPass == "PAGES")
        {
            bookPanel.SetActive(true);
        }
    }

    public void BackButton()
    {
        inputFieldMain.text = ""; //Clears the current display

        //if (wrongPanel == true)
        //{
        //    wrongPanel.SetActive(false);
        //}

    }

    public void LevelReLoad()
    {
        inputFieldMain.text = "STAMPS";
        postPanel.SetActive(true);
        SceneManager.LoadScene("Main Scene");
    }


}
