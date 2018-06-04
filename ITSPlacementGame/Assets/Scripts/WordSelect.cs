using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class WordSelect : MonoBehaviour
{
    public GameObject nextBtn;
    public GameObject iceCreamPanel;

    public GameObject icePanel;
    public GameObject creamPanel;

    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;

    public GameObject retryPanel;

 //   public string firstWord = "ICECREAM";

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

    public void FirstWord()
    {
        nextBtn.SetActive(true);
        iceCreamPanel.SetActive(true);

        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);

        icePanel.SetActive(false);
        creamPanel.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("BookStore1");
    }

    public void WrongWord()
    {
        retryPanel.SetActive(true);

        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);

        icePanel.SetActive(false);
        creamPanel.SetActive(false);
    }
}
