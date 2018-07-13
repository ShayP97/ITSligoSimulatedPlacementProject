using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordShuffle : MonoBehaviour
{

    public GameObject btn1;
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;

    Vector3 newPos;
    Vector3 otherPos;

    int button = 0;

    // Use this for initialization
    void Start()
    {
        button = Random.Range(1, 5);

        SwapButtons();
    }

    void SwapButtons()
    {
        if (button == 1)
        {
            newPos = new Vector3(1156, 280, 0);
            btn1.transform.position = newPos;
            otherPos = new Vector3(520, 280, 0);
            btn2.transform.position = otherPos;
        }

        if (button == 2)
        {
            newPos = new Vector3(520, 108, 0);
            btn2.transform.position = newPos;
            otherPos = new Vector3(1156, 285, 0);
            btn3.transform.position = otherPos;
        }
        if (button == 3)
        {
            newPos = new Vector3(520, 284, 0);
            btn4.transform.position = newPos;
            otherPos = new Vector3(1156, 107, 0);
            btn1.transform.position = otherPos;
        }
        if (button == 4)
        {
            newPos = new Vector3(1156, 285, 0);
            btn4.transform.position = newPos;
            otherPos = new Vector3(1156, 107, 0);
            btn2.transform.position = otherPos;
        }
    }
}
