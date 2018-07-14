using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        gameObject.GetComponent<Graphic>().FadeText();
	}

}
