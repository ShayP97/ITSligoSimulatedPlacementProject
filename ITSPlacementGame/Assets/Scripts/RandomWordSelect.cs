using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWordSelect : MonoBehaviour
{
    public GameObject btn_Panel_1;
    public GameObject btn_Panel_2;
    public GameObject btn_Panel_3;

    int button = 0;

	// Use this for initialization
	void Start ()
    {
        button = Random.Range(1, 5);

        SwapButtons();
	}
	
    void SwapButtons()
    {
        if(button == 1)
        {
            btn_Panel_1.SetActive(true);
            btn_Panel_2.SetActive(false);
            btn_Panel_3.SetActive(false); 
        }

        if (button == 2)
        {
            btn_Panel_2.SetActive(true);
            btn_Panel_1.SetActive(false);
            btn_Panel_3.SetActive(false);
        }
        if (button == 3)
        {
            btn_Panel_3.SetActive(true);
            btn_Panel_1.SetActive(false);
            btn_Panel_2.SetActive(false);
        }

    }

}
