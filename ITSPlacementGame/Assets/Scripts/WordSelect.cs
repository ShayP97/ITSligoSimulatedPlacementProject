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
    public GameObject resultPanel;

    public GameObject pic1Panel;
    public GameObject pic2Panel;
    public GameObject plusPanel;

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

    public void CorrectWord()
    {
        nextBtn.SetActive(true);
        resultPanel.SetActive(true);

        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);

        pic1Panel.SetActive(false);
        pic2Panel.SetActive(false);

        plusPanel.SetActive(false);
    }

    public void Retry()
    {
        SceneManager.LoadScene("BookStore1");
    }

    public void Retry2()
    {
        SceneManager.LoadScene("BookStore_2");
    }

    public void Retry3()
    {
        SceneManager.LoadScene("BookStore_3");
    }

    public void WrongWord()
    {
        retryPanel.SetActive(true);

        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);

        pic1Panel.SetActive(false);
        pic2Panel.SetActive(false);

        plusPanel.SetActive(false);
    }
}
