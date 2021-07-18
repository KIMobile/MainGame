using UnityEngine;
using UnityEngine.UI;

public class InputFieldToText : MonoBehaviour
{
    public InputField Field;
    public Text TextBox;
    public Text Name;

    public static string Anun = "Noname";

    public void CopyText()
    {
        TextBox.text = "Barlus " + Field.text + " axper";
        Name.text = Field.text;
        setAnun();
    }

    private void setAnun()
    {
        Anun = Field.text;
    }

    public static string getAnun()
    {
        return Anun;
    }

}
