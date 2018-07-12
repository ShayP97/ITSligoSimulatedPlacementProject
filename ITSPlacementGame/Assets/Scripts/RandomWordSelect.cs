using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWordSelect : MonoBehaviour
{
    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;

    Vector3 newPos;
    Vector3 otherPos;

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
            newPos = new Vector3(787, 190 , 0);
            btn1.transform.position = newPos;
            otherPos = new Vector3(355, 188, 0);
            btn2.transform.position = otherPos;
        }

        if (button == 2)
        {
            newPos = new Vector3(355, 70, 0);
            btn2.transform.position = newPos;
            otherPos = new Vector3(787, 192, 0);
            btn3.transform.position = otherPos;
        }
        if (button == 3)
        {
            newPos = new Vector3(358, 192, 0);
            btn4.transform.position = newPos;
            otherPos = new Vector3(787, 70, 0);
            btn1.transform.position = otherPos;
        }
        if(button == 4)
        {
            newPos = new Vector3(787, 192, 0);
            btn4.transform.position = newPos;
            otherPos = new Vector3(785, 69, 0);
            btn2.transform.position = otherPos;
        }
    }

}
