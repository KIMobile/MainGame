using UnityEngine;

public class ShowHideLearnButtons : MonoBehaviour
{
    
    public GameObject LearnAlpha;
    public GameObject LearnDigits;


    public void ShowAlphaButton()
    {
        LearnAlpha.SetActive(true);
    }

    public void HideAlphaButton()
    {
        LearnAlpha.SetActive(false);
    }

    public void ShowDigitsButton()
    {
        LearnDigits.SetActive(true);
    }

    public void HideDigitsButton()
    {
        LearnDigits.SetActive(false);
    }


    void Update()
    {
        if(NewPlayer.getIntellect() < 0.1)
        {
            ShowAlphaButton();
        } else
        {
            HideAlphaButton();
        }

        if (NewPlayer.getIntellect() == 0.1)
        {
            ShowDigitsButton();
        } else
        {
            HideDigitsButton();
        }

    }
}
