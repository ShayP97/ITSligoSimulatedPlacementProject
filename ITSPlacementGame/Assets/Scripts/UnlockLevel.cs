using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    public GameObject postPanel;
 
    [SerializeField]
    public Text inputFieldMain;

    public string postPass;

    private void Start()
    {
        inputFieldMain.text = PlayerPrefs.GetString("Password");
    }

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
