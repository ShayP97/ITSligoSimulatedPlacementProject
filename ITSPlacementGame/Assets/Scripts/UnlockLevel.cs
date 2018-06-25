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

    [SerializeField]
    public Text inputFieldBook;

    public string postPass = "STAMPS";
    public string bookPass;

    public static bool visible;

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
       // PlayerPrefs.SetString("Password", postPass);
    }

    public void UnlockBook()
    {
        bookPass = inputFieldBook.text;

        if(bookPass == "PAGES")
        {
            bookPanel.SetActive(true);
        }
    }

    //public void SavePassOnLoad(string pass)
    //{        
    //    inputFieldMain.text = pass;
    //}

    public void LevelReLoad()
    {
        inputFieldMain.text = "STAMPS";
        postPanel.SetActive(true);
        SceneManager.LoadScene("Main Scene");
    }


}
