using UnityEngine;
using UnityEngine.UI;

public class Authorisation : MonoBehaviour
{

    private static string nickname = "";
    public Slider loading;
    private float loadingPercent = 0;
    public GameObject StartButton;
    private  static bool firstStrat = true;
    public Text WelcomeText;
    private static string welcomeMessage = "";


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
        WelcomeText.text = welcomeMessage;
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

        if (loadingPercent == 2000 && firstStrat)
        {
            generateUsernameAndRegister();
        }
        if(loadingPercent == 6000 && firstStrat)
        {
            if(DBManager.register == false)
            {
                generateUsernameAndRegister();
            }
        }
        if (loadingPercent == 9000 && firstStrat)
        {
            if (DBManager.register == false)
            {
                generateUsernameAndRegister();
            }
        }

        if (loading.value >= 1)
        {
            getWelcomeMessage();
            ShowStartButton();
            HideLoading();
            getWelcomeMessage();
        }
        WelcomeText.text = welcomeMessage;
    }

    public static void checkSaveAndSendRequest()
    {
        if (PlayerPrefs.HasKey("tocken"))
        {
            firstStrat = false;
            Debug.Log("Registred User");
            Debug.Log(PlayerPrefs.GetString("nickname"));
            DBManager.checkAuthorization(PlayerPrefs.GetString("tocken"), PlayerPrefs.GetString("hash"));
            setNickname(PlayerPrefs.GetString("nickname"));
        } else
        {
            Debug.Log("First run, need registration");
        }
    }

    private static void generateUsernameAndRegister()
    {
        NewPlayer.setAnun(InputFieldToText.generateUsername());
        DBManager.checkUsername();
    }
    
    public void pressStart()
    {
        if ((getNickname() == "") && (firstStrat))
        {
            Debug.Log("First start");
            welcomeMessage = "Welcome to the Ankap-Pen: Your virtual life.";
            NewPlayer.createNewPlayer();
            SceneChange.startGame();
            savePlayer();
        }
        else if (nickname == DBManager.nickname)
        {
            Debug.Log("Wellcome back " + getNickname());
            welcomeMessage = "Wellcome back " + getNickname() + ", Press START button to continue your saved game";
            NewPlayer.setAnun(getNickname());
            SceneChange.toUserScene();
        }
        else
        {
            Debug.Log("Incorrect save data");
            welcomeMessage = "Something went wrong. Please contact with the Support";
        }
    }

    public void savePlayer()
    {
        if (DBManager.nickname != "")
        {
            Debug.Log(DBManager.nickname);
            Debug.Log(DBManager.tocken);
            Debug.Log(DBManager.hash);
            PlayerPrefs.SetString("nickname", DBManager.nickname);
            PlayerPrefs.SetString("tocken", DBManager.tocken);
            PlayerPrefs.SetString("hash", DBManager.hash);
        }
    }

    private void getWelcomeMessage()
    {
        if ((getNickname() == "") && (firstStrat))
        {
            welcomeMessage = "Welcome to the Ankap-Pen: Your virtual life.";
        }
        else if (nickname == DBManager.nickname)
        {
            welcomeMessage = "Wellcome back " + getNickname() + ", Press START button to continue your saved game";
        }
        else
        {
            welcomeMessage = "Something went wrong. Please contact with the Support";
        }
    }

}
