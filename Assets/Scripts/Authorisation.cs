using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Authorisation : MonoBehaviour
{

    private static string nickname = "";
    public Slider loading;
    private float loadingPercent = 0;
    public GameObject StartButton;

    public void ShowStartButton()
    {
        StartButton.SetActive(true);
    }

    public void HideStartButton()
    {
        StartButton.SetActive(false);
    }

    public void ShowLoading()
    {
        loading.gameObject.SetActive(true);
    }

    public void HideLoading()
    {
        loading.gameObject.SetActive(false);
    }

    public static void setNickname(string name)
    {
        nickname = name;
    }

    public static string getNickname()
    {
        return nickname;
    }


    void Start()
    {
        HideStartButton();
        ShowLoading();
        checkSaveAndSendRequest();
    }

    void Update()
    {
        if (loadingPercent <= 10000)
        {
            loadingPercent ++;
        }
        loading.value = loadingPercent / 10000;
        if (loading.value >= 1)
        {
            ShowStartButton();
            HideLoading();
        }
    }

    public static void checkSaveAndSendRequest()
    {
        
        if (PlayerPrefs.HasKey("tocken"))
        {
            Debug.Log("Registred User");
            Debug.Log(PlayerPrefs.GetString("nickname"));
            setNickname(PlayerPrefs.GetString("nickname"));
        } else
        {
            Debug.Log("First run, need registration");
        }
    }

    public static void printNickname()
    {

        if (getNickname() == "")
        {
            Debug.Log("Incorrect token or hash");
        }
        else
        {
            Debug.Log("Wellcome back " + getNickname());
        }
    }
    

    
}
