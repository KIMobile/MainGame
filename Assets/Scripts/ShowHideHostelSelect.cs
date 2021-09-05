using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideHostelSelect : MonoBehaviour
{

    public GameObject HostelButton;
    public GameObject NextButton;

    public void ShowHostelButton()
    {
        HostelButton.SetActive(true);
    }

    public void HideHostelButton()
    {
        HostelButton.SetActive(false);
    }

    public void ShowNextButton()
    {
        NextButton.SetActive(true);
    }

    public void HideNextButton()
    {
        NextButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(NewPlayer.getHotelPrice() < 0.1)
        {
            HideNextButton();
            ShowHostelButton();
        } else {
            ShowNextButton();
            HideHostelButton();
        }
    }
}
