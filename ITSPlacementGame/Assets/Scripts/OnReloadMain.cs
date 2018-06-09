using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnReloadMain : UnlockLevel
{

	// Use this for initialization
	void Start ()
    {
        postPanel.SetActive(true);
    }
	
 public void RelaodMain()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
