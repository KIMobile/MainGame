using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    public GameObject TestButton;

    public void ShowTestButton()
    {
        TestButton.SetActive(true);
    }

    public void HideTestButton()
    {
        TestButton.SetActive(false);
    }


    void Update()
    {
        if ((NewPlayer.getIntellect() > 0) && (NewPlayer.getIntellect() < 0.2))
        {
            ShowTestButton();
        } else
        {
            HideTestButton();
        }

    }
}
