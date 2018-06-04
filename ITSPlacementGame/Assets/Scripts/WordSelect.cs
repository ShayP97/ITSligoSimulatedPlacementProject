using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class WordSelect : MonoBehaviour
{

    public GameObject correctPanel;
    public GameObject nextBtn;

    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;

 //   public string firstWord = "ICECREAM";

	//// Use this for initialization
	//void Start () {
		
	//}
	
	//// Update is called once per frame
	//void Update () {
		
	//}

   

    public void FirstWord()
    {
        correctPanel.SetActive(true);
        nextBtn.SetActive(true);
        btn1.SetActive(false);
        btn2.SetActive(false);
        btn3.SetActive(false);
        btn4.SetActive(false);
    }
}
