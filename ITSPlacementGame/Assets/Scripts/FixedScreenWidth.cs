using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedScreenWidth : MonoBehaviour
{
    public bool fixedWidth = true;

    float defaultWidth;

	// Use this for initialization
	void Start ()
    {
        defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(fixedWidth)
        {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;
        }
		
	}
}
