using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadBackground : MonoBehaviour
{
    //public KeypadBackground Background;

    public GameObject UnlockButton;
    public Image BackgroundImage;

    public void HideUnlockButton()
    {
        UnlockButton.SetActive(false);
    }

    public void ChangeToSuccessColor()
    {
        BackgroundImage.color = Color.green;
    }
    public void ChangeToFailedColor()
    {
        BackgroundImage.color = Color.red;
    }
    public void ChangeToDefaultColor()
    {
        BackgroundImage.color = Color.grey;
    }
}
