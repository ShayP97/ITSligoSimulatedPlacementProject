using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public GameObject postPanel;
    public GameObject bookPanel;
 
    [SerializeField]
    public Text inputFieldMain;

    [SerializeField]
    public Text inputFieldBook;

    public string postPass;
    public string bookPass;

    //private void Start()
    //{
    //    inputFieldMain.text = PlayerPrefs.GetString("Password");
    //}

    public void UnlockPost()
    {
        postPass = inputFieldMain.text;
      
        if (postPass == "STAMPS")
        {           
            postPanel.SetActive(true);
            //SavePass(postPass);
        }
        PlayerPrefs.SetString("Password", "STAMPS");
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
