using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldToText : MonoBehaviour
{
    public InputField NameInputField;
    public Text TextBox;
    public Text Name;
    private new string name;

    private void Start()
    {
        name = generateUsername();
        NameInputField.placeholder.GetComponent<Text>().text = name;
        NameInputField.text = name;
    }

    private static string generateUsername()
    {
        int num = Random.Range(0, 9999999);
        string username = "Player_" + num.ToString();
        return username;
    }

    private static bool IsUsername(string username)
    {
        string nameRegex = "^[A-Za-z][A-Za-z0-9_]{5,19}$";
        Regex regex = new Regex(nameRegex);
        return regex.IsMatch(username);
    }
    

    public void getTextFromField()
    {
        
        if (NameInputField.text == "")
        {
            Name.text = name;
        } else if (IsUsername(NameInputField.text))
        {
            Name.text = NameInputField.text;
            TextBox.text = "Barlus " + Name.text + " axper";
            NewPlayer.setAnun(Name.text);
            DBManager.checkUsername();
        }
        else
        {
            TextBox.text = "Username is incorrect.";
        }
        
    }

    public void savePlayer()
    {
        if(DBManager.nickname != "")
        {
            Debug.Log(DBManager.nickname);
            Debug.Log(DBManager.tocken);
            Debug.Log(DBManager.hash);
            PlayerPrefs.SetString("nickname", DBManager.nickname);
            PlayerPrefs.SetString("tocken", DBManager.tocken);
            PlayerPrefs.SetString("hash", DBManager.hash);
        }
    }

}
