using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureFlip : MonoBehaviour
{
    public GameObject picPanel;

    public void PicSwap()
    {
        picPanel.SetActive(true);
    }

    public void PicSwapBack()
    {
        picPanel.SetActive(false);
    }

}
