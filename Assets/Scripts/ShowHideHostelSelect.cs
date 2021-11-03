using UnityEngine;
using UnityEngine.UI;

public class ShowHideHostelSelect : MonoBehaviour
{

    public GameObject HostelButton;
    public GameObject NextButton;
    public Text welcomeText;

    public static string lang;

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

    void Start()
    {
        Debug.Log(Application.systemLanguage);
        lang = NewPlayer.Lang;
    }

    // Update is called once per frame
    void Update()
    {
        if(NewPlayer.getHotelPrice() < 0.1)
        {
            HideNextButton();
            ShowHostelButton();
            welcomeText.text = Messages.HOSTEL_WELCOME_MESSAGE[lang];
        } else {
            ShowNextButton();
            HideHostelButton();
        }
    }
}
