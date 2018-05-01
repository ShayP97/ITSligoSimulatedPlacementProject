using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableLetters : MonoBehaviour
{
    public string DraggableLetter = "Letter";
    public bool beingDragged = false;

    private Vector2 originalPos;

    private Transform letterToDrag;
    private Image letterToDragImage;

    List<RaycastResult> hitLetters = new List<RaycastResult>();
	
	void Update ()
    {
		if(Input.GetMouseButtonDown(0))
        {
            letterToDrag = GetLetterTransform();

            if(letterToDrag != null)
            {
                beingDragged = true;
                letterToDrag.SetAsLastSibling();

                originalPos = letterToDrag.position;
                letterToDragImage = letterToDrag.GetComponent<Image>();
                letterToDragImage.raycastTarget = false;
            }
        }

        if(beingDragged)
        {
            letterToDrag.position = Input.mousePosition;
        }

        if(Input.GetMouseButtonUp(0))
        {
            if(letterToDrag != null)
            {
                Transform letterToReplace = GetLetterTransform();

                if(letterToReplace != null)
                {
                    letterToDrag.position = letterToReplace.position;
                    letterToReplace.position = originalPos;
                }
                else
                {
                    letterToDrag.position = originalPos;
                }

                letterToDragImage.raycastTarget = true;
                letterToDrag = null;
            }

            beingDragged = false;
        }
	}

    private GameObject GetLetter()
    {
        var pointer = new PointerEventData(EventSystem.current);

        pointer.position = Input.mousePosition;

        EventSystem.current.RaycastAll(pointer, hitLetters);

        if(hitLetters.Count <= 0)
        {
            return null;
        }
        else
        {
            return hitLetters.First().gameObject; //returns the first gameobject detected or selected
        }
    }

    private Transform GetLetterTransform()
    {
        GameObject selectedLetter = GetLetter();

        if(selectedLetter != null && selectedLetter.tag == DraggableLetter )
        {
            return selectedLetter.transform;
        }

        return null;    
    }
}
